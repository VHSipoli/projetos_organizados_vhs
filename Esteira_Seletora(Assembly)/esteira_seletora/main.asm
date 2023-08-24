.org 0x000 ;endereço de inicio de gravacao memoria flash
.equ	baud	= 9600			; baudrate
.equ	bps	= 103	; baud prescale
.equ aux =0;

ldi	r16,LOW(bps)			; load baud prescale
ldi	r17,HIGH(bps)			; into r17:r16
rcall	initUART			; call initUART subroutine

/*
o pino pb5 é para teste ver até aonde estamos chegando na eletronica
comentário para entender o que é e onde esta os sensores

Aonde fica cada sensor
Sensor Indutivo = pc0
sensor capacitivo = pc1
sensor FimDeCurso = pc2

sensor alto = pd2
sensor medio= pd3
sensor baixo= pd4
conta  alto = pd5
conta  medio= pd6
conta  baixo= pd7

VALVULA 1   = pb0
VALVULA 2   = pb1
VALVULA 3A  = pb2
VALVULA 3R  = pb4
LED TESTE   = pb5
*/

;metal:	.db	"Metal: ",$00
;plast:	.db	"PLástico: ",$00

myStr09:	.db	"IFSP_Catanduva!",$00 ;cabecalho
myStr08:	.db"Esteira_Seletora",$00 ;cabecalho

;myStr28:	.db"(1) Ligar",$00			;modo_remoto
;myStr27:	.db"(2) Desligar",$00		;modo_remoto

met:		.db"Eh metal:" ,$00	;contagem
pla:		.db"Eh Plastico:" ,$00	;contagem
metalG:		.db"Grande:" ,$00	;contagem	
metalM:		.db"Medio:" ,$00	;contagem	
metalP:		.db"Pequeno:" ,$00	;contagem	

rjmp cabecalho

MAIN:

	
	LDI	R16,LOW(bps)			; load baud prescale
	lDI	R17,HIGH(bps)			; into r17:r16

	LDI R19, 0b00111111 ;
	OUT DDRB, R19 ;DEFINE COMO SAIDA
	LDI R19, 0b00000000
	OUT PORTB, R19 ;COMECA DESLIGADO

	LDI R19, 0b00000000 ;
	OUT DDRC, R19 ;DEFINE COMO ENTRADA
	LDI R19, 0b00000000
	OUT PORTC, R19 ;ATIVA PULL-down

	LDI R19, 0b00000000 ;
	OUT DDRD, R19 ;DEFINE COMO ENTRADA
	LDI R19, 0b00000000
	OUT PORTD, R19 ;ATIVA PULL-down

	SBI PORTB,3 ;LIGANDO MOTOR


	LOOP:				;espera peça
		cbi portb, pb0
		cbi portb, pb1
		cbi portb, pb2
		sbi portb, pb4

		sbic PINC, 0	;ve se é metal
		rjmp cont_metal

		sbic PINC, 1	;ve se é plastico
		rjmp cont_plastico
		rjmp LOOP


	cont_metal:
		inc r20
		ldi	ZL,LOW(2*met)			; load Z pointer with
		ldi	ZH,HIGH(2*met)		; myStr address
		rcall puts			; transmit character
		ldi	r16,10			; load char 'a' into r16
		rcall	putc				; transmit character
		rjmp Metal

	Metal:
		sbi portb, pb5 ;ledteste
		sbic PIND, 2	;testa se é metal grande
		rjmp Cont_Fvalvula1	;para deslocar para conta alto

		sbic PIND, 3
		rjmp Cont_Fvalvula2

		sbic PIND, 4
		rjmp Cont_Fvalvula3
		rjmp Metal		;se ainda não leu nem uma altura volta pro Metal
		

	cont_plastico:
		inc r21
		ldi	ZL,LOW(2*pla)			; load Z pointer with
		ldi	ZH,HIGH(2*pla)		; myStr address
		rcall puts			; transmit character
		ldi	r16,10			; load char 'a' into r16
		rcall	putc				; transmit character
		RJMP Plastico		;se ainda não chegou no fim_de_curso volta pro plastico

	Plastico:		
		sbic PINC, 2		;testa se é plastico
		rjmp LOOP			;DEPOIS ADD PLASTICO
		RJMP Plastico		;se ainda não chegou no fim_de_curso volta pro plastico


		Cont_Fvalvula1:
		inc r22
		ldi	ZL,LOW(2*metalG)			; load Z pointer with
		ldi	ZH,HIGH(2*metalG)		; myStr address
		rcall puts			; transmit character
		ldi	r16,10			; load char 'a' into r16
		rcall	putc				; transmit character
		RJMP Fvalvula1		;se ainda não chegou no fim_de_curso volta pro plastico

		Fvalvula1:
			sbi portb, pb0      ;aciona a minha válvula1	
			sbic pind, 5		;testa o conta alto
								;se ja caiu no armazenamento de alto
			rjmp LOOP			;se já caiu volta pro loop
			rjmp Fvalvula1		;se não caiu espera cair

		Cont_Fvalvula2:
		inc r23
		ldi	ZL,LOW(2*metalM)			; load Z pointer with
		ldi	ZH,HIGH(2*metalM)		; myStr address
		rcall puts			; transmit character
		ldi	r16,10			; load char 'a' into r16
		rcall	putc				; transmit character
		RJMP Fvalvula2		;se ainda não chegou no fim_de_curso volta pro plastico

		Fvalvula2:
			sbi portb, pb1      ;aciona a minha válvula2	
			sbic pind, 6		;testa o conta médio
								;se ja caiu no armazenamento de médio
			rjmp LOOP			;testa se já caiu volta pro loop
			rjmp Fvalvula2		;se não caiu espera cair

		Cont_Fvalvula3:
		inc r24
		ldi	ZL,LOW(2*metalP)			; load Z pointer with
		ldi	ZH,HIGH(2*metalP)		; myStr address
		rcall puts			; transmit character
		ldi	r16,10			; load char 'a' into r16
		rcall	putc				; transmit character
		RJMP Fvalvula3		;se ainda não chegou no fim_de_curso volta pro plastico

		Fvalvula3:
			sbi portb, pb2      ;aciona	válvula 3 de avanço	
			cbi portb, pb3		;desaciona válvula 3 de retorno
			sbic pind, 7		;testa o conta baixo
								;se ja caiu no armazenamento de baixo
			rjmp LOOP			;testa se já caiu volta pro loop
			rjmp Fvalvula3		;se não caiu espera cair


		initUART:
			sts	UBRR0L,r16			; load baud prescale
			sts	UBRR0H,r17			; to UBRR0

			ldi	r16,(1<<RXEN0)|(1<<TXEN0)	; enable transmitter
			sts	UCSR0B,r16			; and receiver

			ret					; return from subroutine

;--------------LEITURAS-----------------------------------------------------
puts:	
	lpm	r16,Z+				; load character from pmem
	cpi	r16,$00				; check if null
	breq	puts_end			; branch if null

puts_wait:
	lds	r17,UCSR0A			; load UCSR0A into r17
	sbrs	r17,UDRE0			; wait for empty transmit buffer
	rjmp	puts_wait			; repeat loop

	sts	UDR0,r16			; transmit character
	rjmp	puts				; repeat loop

puts_end:
	ret					; return from subroutine

putc:	lds	r17,UCSR0A			; load UCSR0A into r17
sbrs	r17,UDRE0			; wait for empty transmit buffer
rjmp	putc				; repeat loop
sts	UDR0,r16			; transmit character
ret					; return from subroutine


	;------------CABECALHO---------------------------
cabecalho:


	ldi	ZL,LOW(2*myStr09)			; load Z pointer with
	ldi	ZH,HIGH(2*myStr09)		; myStr address
	rcall	puts
	ldi	r16,10			; load char 'a' into r16
	rcall	putc				; transmit character
	ldi	ZL,LOW(2*myStr08)			; load Z pointer with
	ldi	ZH,HIGH(2*myStr08)		; myStr address
	rcall puts
	ldi	r16,10			; load char 'a' into r16
	rcall	putc

	rjmp MAIN

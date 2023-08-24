#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<time.h>
#include "agenda.c"

int main(){

time_t t = time(NULL);
struct tm tm=*localtime(&t);
int hora=tm.tm_hour;
int minutos=tm.tm_min;
int dia=tm.tm_mday;
int mes=tm.tm_mon+1;
int ano=tm.tm_year+1900;


	int opc;
    int cont9=0;
	do{
		system("cls");
        printf("\nHoje e %d/%d/%d\n",dia,mes,ano);
        printf("\nAgora sao %dh%dmin\n\n",hora,minutos);
		printf("Agenda do Lobato\n");
        printf("\nTem %d contato(s) na sua agenda\n",cont9);
		printf("1 - Adicionar pessoa\n");
		printf("2 - Buscar contato por nomes\n");
		printf("3 - Buscar contato por email\n");
		printf("4 - Ver todos os contatos\n");
		printf("5 - Ver todos aniversariantes do mes\n");
		printf("9 - Sair\n\n");

		scanf("%d", &opc);

		switch(opc){
		case 1:
			adicionar();
			cont9++;
			system("pause");
			break;

		case 2:
			buscar_nome();
            printf("\n\n");
			system("pause");
			break;

        case 3:
            buscar_email();
            printf("\n\n");
			system("pause");
			break;

		case 4:
			contatos();
            printf("\n\n");
			system("pause");
			break;

        case 5:
            niver_mes();
            printf("\n\n");
			system("pause");
			break;

        case 9:
            printf("\n=========\nSaindo\n=========\n");
}
	}while(opc!=9);

	return 0;
}





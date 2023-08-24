#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include<time.h>
#include "agenda.h"

int cont=0;

void adicionar(){
	system("cls");

	fflush(stdin);//Limpa Buffer
	printf("\n%d.Nome do contato:", (cont+1));
	gets(CONTROL[cont].nom);

    fflush(stdin);
	printf("\nE-mail:");
	gets(CONTROL[cont].email);

    fflush(stdin);
	printf("\nCelular:");
	gets(CONTROL[cont].cel);

	fflush(stdin);
	printf("\nTelefone:");
	gets(CONTROL[cont].tel);

    fflush(stdin);
	printf("\nDia:");
	scanf("%d",&CONTROL[cont].dia);

    fflush(stdin);
	printf("\nMes:");
	scanf("%d",&CONTROL[cont].mes);

    fflush(stdin);
	printf("\nAno:");
	scanf("%d",&CONTROL[cont].ano);

	cont++;

}

void buscar_nome(){

struct tm *data_hora_atual;
time_t abc;
time(&abc);
data_hora_atual = localtime(&abc);

	char busca[30];
	int i;


	system("cls");

	fflush(stdin);
	printf("\nDigite o nome que deseja procurar\n");
	gets(busca);

	for(i=0;i<cont;i++){
        if(strcmp(busca,CONTROL[i].nom)==0){
        printf("\nNome: %s\n", CONTROL[i].nom);
        printf("Telefone: %s\n", CONTROL[i].tel);
        printf("Celular: %s\n", CONTROL[i].cel);
        printf("E-mail: %s\n", CONTROL[i].email);
        printf("Data de Nascimento: %d/%d/%d\n",CONTROL[i].dia, CONTROL[i].mes,CONTROL[i].ano);

        //antes
        if((data_hora_atual->tm_mon+1)>CONTROL[i].mes){
            printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano));}

        //meio
        if((data_hora_atual->tm_mon+1)==CONTROL[i].mes){
           if(data_hora_atual->tm_mday>=CONTROL[i].dia){
            printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano));}
            else{printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano)-1);}
            }

        //depois
        if((data_hora_atual->tm_mon+1)<CONTROL[i].mes){
                printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano)-1);}

        }
	}

}

void buscar_email(){

struct tm *data_hora_atual;
time_t abc;
time(&abc);
data_hora_atual = localtime(&abc);

    char busca2[15];
	int i;

	system("cls");

	fflush(stdin);
	printf("\nDigite o email que deseja procurar\n");
	gets(busca2);

	for(i=0;i<cont;i++){
         if(strcmp(busca2,CONTROL[i].email)==0){
        printf("\nE-mail: %s\n", CONTROL[i].email);
        printf("Nome: %s\n", CONTROL[i].nom);
        printf("Telefone: %s\n", CONTROL[i].tel);
        printf("Celular: %s\n", CONTROL[i].cel);
        printf("Data de Nascimento: %d/%d/%d\n",CONTROL[i].dia, CONTROL[i].mes,CONTROL[i].ano);

        //antes
        if((data_hora_atual->tm_mon+1)>CONTROL[i].mes){
            printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano));}

        //meio
        if((data_hora_atual->tm_mon+1)==CONTROL[i].mes){
           if(data_hora_atual->tm_mday>=CONTROL[i].dia){
            printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano));}
            else{printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano)-1);}
            }

        //depois
        if((data_hora_atual->tm_mon+1)<CONTROL[i].mes){
                printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano)-1);}

        }
	}

}

void contatos(){

struct tm *data_hora_atual;
time_t abc;
time(&abc);
data_hora_atual = localtime(&abc);

	int i, j,aux;
	char auxc[50];

	system("cls");

	for(i=0;i<cont-1;i++){
		for(j=0;j<cont-1-i;j++){
			if(strcmp(CONTROL[j].nom,CONTROL[j+1].nom)>0){

				strcpy(auxc,CONTROL[j].nom);
				strcpy(CONTROL[j].nom,CONTROL[j+1].nom);
				strcpy(CONTROL[j+1].nom,auxc);

				strcpy(auxc,CONTROL[j].tel);
				strcpy(CONTROL[j].tel,CONTROL[j+1].tel);
				strcpy(CONTROL[j+1].tel,auxc);

				strcpy(auxc,CONTROL[j].email);
				strcpy(CONTROL[j].email,CONTROL[j+1].email);
				strcpy(CONTROL[j+1].email,auxc);

				aux = CONTROL[j].ano;
				CONTROL[j].ano = CONTROL[j+1].ano;
				CONTROL[j+1].ano = aux;

				aux = CONTROL[j].mes;
				CONTROL[j].mes = CONTROL[j+1].mes;
				CONTROL[j+1].mes = aux;

			}
		}
	}

	printf("Agenda.\n");

	for(i=0;i<cont;i++){
		printf("\n%d.Nome: %s\n",(i+1), CONTROL[i].nom);
		printf("Telefone: %s\n", CONTROL[i].tel);
        printf("Celular: %s\n", CONTROL[i].cel);
		printf("E-mail: %s\n", CONTROL[i].email);
        printf("Data de Nascimento: %d/%d/%d\n",CONTROL[i].dia, CONTROL[i].mes,CONTROL[i].ano);

        //antes
        if((data_hora_atual->tm_mon+1)>CONTROL[i].mes){
            printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano));}

        //meio
        if((data_hora_atual->tm_mon+1)==CONTROL[i].mes){
           if(data_hora_atual->tm_mday>=CONTROL[i].dia){
            printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano));}
            else{printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano)-1);}
            }

        //depois
        if((data_hora_atual->tm_mon+1)<CONTROL[i].mes){
                printf("Idade: %d\n",(data_hora_atual->tm_year+1900)-(CONTROL[i].ano)-1);}

	}

}

void niver_mes(){

    int busca2;
	int i;

	system("cls");

	fflush(stdin);
	printf("\nDigite numero do mes que queres ver os aniversariantes:\n");
	printf("\n01.Janeiro\t02.Fevereiro\t03.Marco\n04.Abril\t05.Maio\t\t06.Junho\n07.Julho\t08.Agosto\t09.Setembro\n10.Outubro\t11.Novembro\t12.Dezembro\n");
	scanf("%d",&busca2);
    printf("\nAniversariantes do mes %d:\n\n",busca2);

    for(i=0;i<cont;i++){

    switch(busca2){
    case 1:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

     case 2:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 3:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 4:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 5:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 6:
        if(CONTROL[i].mes==busca2){
            printf("\n%s\n",CONTROL[i].nom);
        }
        break;

    case 7:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 8:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 9:
        if(CONTROL[i].mes==busca2){
            printf("\n%s\n",CONTROL[i].nom);
        }
        break;

    case 10:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 11:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    case 12:
        if(CONTROL[i].mes==busca2){
            printf("%s\n",CONTROL[i].nom);
        }
        break;

    }

    }

    }



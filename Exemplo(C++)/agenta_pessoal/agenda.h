#ifndef AGENDA_H_INCLUDED
#define AGENDA_H_INCLUDED


struct agenda {
	char nom[30];
	char tel[20];
    char cel[20];
	char email[40] ;
	int ano;
	int mes;
    int dia;
	int idade;
} CONTROL[100];

void adicionar();
void buscar_nome();
void buscar_email();
void contatos();
void niver_mes();


#endif // AGENDA_H_INCLUDED

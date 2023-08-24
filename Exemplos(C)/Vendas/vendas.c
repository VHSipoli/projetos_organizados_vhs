#include <stdio.h>
#include<stdlib.h>

int main ()
{
  char formaPG;
  float v=0,tv=0,tp=0,t=0,maior=0,menor=0;
  int cont,qv,qp;

  for (cont=  1; cont <= 10; cont++)

  {
    do
    {
      printf("Digite a forma de pagamento: V a vista ou P a prazo\n");
      scanf("%c", &formaPG);
      formaPG=toupper(formaPG);
    }

    while ((formaPG=!'V')&&(formaPG!='P'));
    printf("Digite o valor da venda:");
    scanf("%f",&v);
    t+=v;

    if(formaPG=='V')
    {
      qv++;
      tv+=v;
    }
    else
    {
      qp++;
      tp+=v;}


    }
  }


#include <stdio.h>

int main ()
{
  int i,n,f=1;
    printf("\nDigite um valor inteiro n�o negativo\n");
    scanf("%d",&n);
    i=1;
  while(i<=n)
  {
    f*=i;
    i++;
  }
  printf("Fatorial=%d\n",f);
  return 0;
}

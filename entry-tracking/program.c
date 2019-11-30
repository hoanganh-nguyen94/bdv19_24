#include <stdio.h>
#include <stdlib.h>

int main()
{
  char c;
  FILE *from, *to;

  from = fopen("input.txt", "r");
  if (from == NULL)
  {
    perror("file.txt doesn't exist.");
    exit(1);
  }

  to = fopen("output.txt", "w");
  if (to == NULL)
    {
      perror("output.txt doesn't exist.");
      exit(1);
    }
  do
    {
      c = getc(from);
      putc(c, to);
    }
  while(c != EOF);
  fclose(to);
  fclose(from);
  exit(0);
}
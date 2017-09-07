using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStream
{
    public interface IStream
    {
        char getNext();

        Boolean hasNext();
    }

    public class StreamString : IStream
    {
        public string stream;

        private int count = 0;

        public StreamString(String stream)
        {
            this.stream = stream;
        }

        public char getNext()
        {
            return this.stream[count++];
        }

        public bool hasNext()
        {
            return this.stream.Length > count;
        }

        public char firstChar(IStream input)
        {
            char c;

            while (input.hasNext())
            {
                c = input.getNext();

                //Sabemos que a regra é encontrar uma vogal após uma consoante, então sempre iniciamos verificando se trata de uma consoante
                if (EhConsoante(c))
                {
                    //Caso seja uma consoante, devemos verificar se existe caracter após a mesma
                    if (input.hasNext())
                    {
                        //Obtendo o próximo caractere
                        c = input.getNext();

                        //Verificamos se esse caractere obtido trata-se de uma vogal
                        if (!EhConsoante(c))
                        {
                            //Verificamos a quantidade de repetiçoes dessa vogal
                            int qtd = QuantidadeVogal(c);

                            //Se só existir uma vogal, encontramos um resultado válido
                            if (qtd == 1)
                            {
                                return c;
                            }
                        }
                        else
                        {
                            //Caso seja uma consoante seguida de outra consoante, temos que continuar a verificação do próximo char e verificar se é vogal
                            if (input.hasNext())
                            {
                                //Obtendo o próximo caractere
                                c = input.getNext();

                                //Verificamos se esse caractere obtido trata-se de uma vogal
                                if (!EhConsoante(c))
                                {
                                    //Verificamos a quantidade de repetiçoes dessa vogal
                                    int qtd = QuantidadeVogal(c);

                                    //Se só existir uma vogal, encontramos um resultado válido
                                    if (qtd == 1)
                                    {
                                        return c;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return ' ';
        }

        //Método para conta a quantidade de vogais no stream
        private int QuantidadeVogal(char vogal)
        {
            return this.stream.Count(x => x == vogal);
        }

        //Método para verificar se o char se trata de uma Consoante
        private bool EhConsoante(char c)
        {
            switch (c)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'U':
                case 'u':
                    return false;
                default:
                    return true;
            }
        }
    }
}

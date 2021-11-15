using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace tp1nouha
{
    class Tableau
    {
        private int dim;
        private int[] array;
        private int i;
        private int z = 0; // on a declare  z seulement pour savoir si la methode est realise ou nn



        public Tableau(int dim) //le constructeur
        {
            array = new int[dim]; // allouer une espace dans la memoire 
            this.dim = dim; // pointer
        }
        //la fonction d'insertion
        public void Insert(int i, int valeur)  //valeur c est la valeurs qui va entrer utilisateur et index c est la position de la valeurs en tableau
        {
            this.i = i;
            if (i < dim)
            {
                Console.WriteLine("Hello World!");
                array[i] = valeur;//inserer la valeurs entrer par l utilisateur
            }
        }
        //la fonction de suppression
        public int Suppresion(int position)

        {
            if (position > dim || position < 0)
            {
                z = 0;
            }
            else
            {
                for (i = position; i <= dim - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                z = 1;
            }
            return z;

        }
        //la fonction de recherche
        public int Recherche(int seek)// on recherche a l aide du seek
        {
            i = 0;//la recharche commence a zero
            while (i < dim && seek != array[i])
            {
                i++;
            }
            if (i < dim)
            {
                z = 1;
            }
            return z;
        }
        //la fonction de triage
        public int Tri(int j)
        {
            int tmp, index;
            //trier un tableau par ordre croissant
            for (i = 0; i < (dim - 1); i++)
            {
                index = i;
                for (j = i + 1; j < dim; j++)
                {
                    if (array[index] > array[j])
                        index = j;
                }
                if (index != i)
                {
                    tmp = array[i]; // on stocke array[i]en tmp
                    array[i] = array[index];
                    array[index] = tmp;
                }
            }

            return 0;
        }
        //la fonction fusionner de 2 tableaux
        public int fusionner(int dim1)
        {
            int[] array1;
            array1 = new int[dim1];
            //fusionner les éléments de deux tableaux array et array1
            array = array.Concat(array1).ToArray();
            array1.CopyTo(array, dim);

            return dim + dim1;
        }

    }
}

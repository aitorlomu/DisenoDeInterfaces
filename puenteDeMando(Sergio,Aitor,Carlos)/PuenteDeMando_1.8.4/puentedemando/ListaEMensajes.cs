using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuenteDeMando
{
    class ListaEMensajes
    {
        class Node {
            //Attributes
            public Mensaje data;
            public Node next;

            //Builders
            /*public Node () {
                next = null;
                data = new Personages();
            }*/

            public Node (Mensaje pdata) {
                next = null;
                data = pdata;
            }
        }


    //*********************************************************
    //*********************************************************
    
    private Node first;

    //---------------------------------------------
    public ListaEMensajes () {
        Empty_List ();
    }
        
    //---------------------------------------------
    public void Empty_List () {
        first = null;
    }

    //---------------------------------------------
    public Boolean Is_Empty() {
        return first == null;
    }

    //---------------------------------------------

    public void Add_First(Mensaje s)
    {
        Node newsquare= new Node(s);

        if (first == null) 
            first = newsquare;
        else {
            newsquare.next = first;
            first = newsquare;
        }
     }


    //---------------------------------------------
    public void Add_Last(Mensaje s)
    {
        Node aux = new Node(s);
        Node rec_aux;

        if (first == null) {
            aux.next = first;
            first = aux;
        }
        else {
            rec_aux = first;
            while (rec_aux.next!=null)
                rec_aux = rec_aux.next;            
            rec_aux.next = aux;
        }
    }


    //---------------------------------------------
    public void Remove_First () {
        Node aux;

        if (!Is_Empty()) {
            aux = first;
            first = first.next;
            aux = null;  // mark as rubbish
        }
    }

    //---------------------------------------------
    public void Remove_Last () {

        Node aux = first;
        if (aux.next == null) 
            Empty_List();
        
        if (!Is_Empty()) {
            aux = first;
            while (aux.next.next!=null)
                aux = aux.next;
            aux.next = null;
        }

    }

    //---------------------------------------------
    public Mensaje Get_Last() {
        Mensaje element= null;
        Node aux = null;

        if (!Is_Empty()) {
            aux = first;
            while (aux.next != null)
                aux = aux.next;
            element = aux.data;
        }
        return element;
    }

    //---------------------------------------------
    public Mensaje Get_First() {
        Mensaje element = null;

        if (!Is_Empty()) 
            element = first.data;        
        return element;
    }


    //---------------------------------------------
    public int elements() {
        Node aux = null;
        int i=0;
        aux = first;

        while (aux!=null){
            aux = aux.next;
            i += 1;
        }
        return i;
    }

    //---------------------------------------------
    public void Add_Position (int position, Mensaje s) {

         if (first == null)  // (Esta_vacio()) si no tiene ningúna casilla:
            first = new Node(s);
         else {

            Node newSquare = new Node(s); //creamos un nuevo nodo con la muestra
            // hay que tener en cuenta que la posicion sea la primera u otra distinta
            if (position == 0) {
                //si es la primera sólo hay que añadirle el nuevo nodo a primero
                newSquare.next = first; //Insertar_Primero(muestra)
                first = newSquare;
            }
            else {
                int cont = 0;
                Node aux = first;
                Node ant = null;
                //para llegar a la posición y añadir la nueva muestra:
                while ((aux!=null) && (cont != position)) { //mientras que aux no apunte a null
                    ant = aux;
                    aux = aux.next;
                    cont += 1;
                }
                ant.next = newSquare;
                newSquare.next = aux;
            }
        }
    }

    //------------------------------------------
    public void Remove_Position (int position) {
 
         //Las posiciones empiezan desde 1.
        Node aux, ant;
        int cont = 1;

        aux = first;
        ant = null;
        while ( aux != null) {
            if (position == cont)
            {
                if (ant == null)  //Primero
                    first = first.next;
                else
                {
                    ant.next = aux.next;
                    aux = null;  //Para que borre efectivamente el nodo.
                }
            }
            else
            {
                ant = aux;
                aux = aux.next;
                cont += 1;
            }
        }
    }

    /*public void Print()
    {
        ListaEMensajes laux = new ListaEMensajes();
        while (!this.Is_Empty())
        {
            laux.Add_Last(this.Get_First());
            Console.WriteLine("i:" + this.Get_First().getPositioni() + " j:" + this.Get_First().getPositionj() + "  " + this.Get_First().getName());
            this.Remove_First();
        }

        first = laux.first;
        Console.WriteLine();
    }*/


    }
}

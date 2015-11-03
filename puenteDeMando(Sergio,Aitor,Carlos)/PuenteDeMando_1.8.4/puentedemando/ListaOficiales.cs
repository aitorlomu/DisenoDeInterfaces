using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuenteDeMando
{
    public class ListaOficiales
    {
        class Node
        {
             //Attributes
            public Oficial data;
            public Node next;

            //Builders
            public Node () {
                next = null;
                data = new Oficial();
            }

            public Node(Oficial pdata)
            {
                this.next = null;
                this.data = pdata;
            }
        }
            private Node first;

    //---------------------------------------------
    public ListaOficiales () {
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

    public void Add_First(Oficial s)
    {
         Node newcharacter = new Node(s);

        if (first == null) 
            first = newcharacter;
        else {
            newcharacter.next = first;
            first = newcharacter;
        }
     }


    //---------------------------------------------
    public void Add_Last(Oficial s)
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
    public Oficial Get_Last()
    {
        Oficial element = null;
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
    public Oficial Get_First()
    {
        Oficial element = null;

        if (this.first != null)
        {
            element = first.data;
        }
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
    public void Add_Position(int position, Oficial s)
    {
        Node aux = new Node(s);
        Node rec_aux;

       rec_aux = first;
            for (int i = 1; i <= position;i++ )
            {
                if (i == position)
                {
                    if (i == 1)
                    {
                        Add_First(s);
                    }
                    else
                    {
                        aux.next = rec_aux.next;
                        rec_aux.next = aux;
                    }
                }
                else { 
                    rec_aux = rec_aux.next;
                }
            }
    }

    //------------------------------------------
    public void Remove_Position (int position) {
        Node aux;
        Node rec_aux;
        rec_aux = first;
        Boolean borrado = false;
        if (position == 1) { Remove_First(); borrado = true; }
        if (position == elements()) { Remove_Last(); borrado = true; }
            for (int i = 2; i <= position; i++)
            {
                if (borrado == true) { break; }
                if (i == position)
                {
                    aux = rec_aux.next;
                    rec_aux.next = aux.next;
                    borrado = true;
                }
                else
                {
                    rec_aux = rec_aux.next;
                }
            }
    }
    //---------------------------------------------
    public Oficial getPosition(int position)
    {
        Node rec_aux;
        Oficial aux = null;
        rec_aux = first;
        for (int i = 1; i <= position; i++)
        {
            if (i == position)
            {
                aux = rec_aux.data;
            }
            else
            {
                rec_aux = rec_aux.next;
            }
        }
        return aux;
    }
    //---------------------------------------------
        //Metodo que busca la posicion del oficial por su nombre
    public int getOficial(String nombre)
    {
        Node rec_aux;
        rec_aux = first;
        Oficial aux;
        for (int i = 1; i <= elements(); i++)
        {
            aux = rec_aux.data;
            if (aux.getNombre().Equals(nombre)== true)
            {
                return i;
            }
            else
            {
                rec_aux = rec_aux.next;
            }
        }
        return 0;
    }
     
    }
}

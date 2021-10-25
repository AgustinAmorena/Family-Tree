using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Persona persona;

        private List<Node> children = new List<Node>();

        public int Persona {
            get
            {
                return this.persona;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int Persona)
        {
            this.persona = Persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}

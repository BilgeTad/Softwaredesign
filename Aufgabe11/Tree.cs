using System;
using System.Collections.Generic;

namespace Aufgabe11
{
    
    public class Tree <T>
    {
        public T Data;
        public List<Tree<T>> list = new List<Tree<T>>();
        

        public Tree<T> CreateNode(T data)
        {
            Tree<T> newNode = new Tree<T>
            {
                Data = data
            };
            return newNode;
        }
        public void AppendChild(Tree<T> child)
        {
            list.Add(child);
        }

        public void RemoveChild(Tree<T> child)

        {
            list.Remove(child);
        }

        public void PrintTree(String AddTree = "")
        {
            Console.WriteLine(AddTree + Data);
            foreach (Tree<T> child in list)
            {
                child.PrintTree(AddTree + "*");
            }
        }

        
        public void ForEach(Action<string> func)
        {         
            for (int i = 0; i < list.Count; i++)
            {
                func(list[i].ToString());
                list[i].ForEach(Program.Func);
            }

        }
        public override string ToString()

        {
            return Data.ToString();
        }

    }
}
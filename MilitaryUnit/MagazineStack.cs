using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    public class MagazineStack
    {
        private readonly int[] ammo;
        private int top;
        private readonly int size;


        public MagazineStack() 
        {
            this.size = 30;
            this.ammo = new int [size];
            this.top = size - 1;
        }
        public MagazineStack(int maxsize)
        {
            this.size = maxsize;
            this.ammo = new int[size];
            this.top = size -1;
        }

        public Boolean IsEmpty() => top == -1;

        public Boolean IsFull() => top == ammo.Length -1;

        public void Reload() 
        {
            for (int i = 0; i < size; i++)
            {
                InsertRound();
            }
        }
        public void Clear() => top = -1;
        
        public void InsertRound() // push
        {
            if (!IsFull()) ammo[++top] = 1;
           
        }


        public int PullTrigger() // pop
        {
            if (IsEmpty())
            {
                return -1;
            }

            return ammo[top--];
        }

        public int Top()
        {
            if (IsEmpty())
            {
                return -1;
            }

            return ammo[top];
        }
    }
}

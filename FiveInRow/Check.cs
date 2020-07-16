using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveInRow
{
    class Check
    {
        private int turn = 0;

        int[] board = new int[100];

        public Check()
        {
            for(int i = 0; i < 100; i++)
            {
                board[i] = i;
            }
        }

        public void onChip(int num, bool which)
        {
            if (which)
                board[num] = 100;
            else
                board[num] = -1;
        }
        
        public bool getTurn()
        {
            return turn % 2 == 0;
        }

        public void nextTurn()
        {
            turn++;
        }

        public bool isFive()
        {
            int point = 0;
            int count = 1;
            int[] vector = new int[8]{ -11,-10,-9,-1,1,9,10,11};
            for (int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    point = i;
                    if (board[i] == 100 || board[i] == -1)
                    {
                        while (point >= 0 && point <= 99)
                        {
                            if (board[i] != board[point]) break;
                            else if (count == 5) return true;
                            else count++;
                            if (j == 3 && (i + vector[j]) % 10 == 9) break;
                            if (j == 4 && (i + vector[j]) % 10 == 0) break;
                            point += vector[j];
                        }
                        count = 1;
                    }
                }
                
            }

            return false;
        }
    }
}

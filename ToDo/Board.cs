using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Board
    {
        
        public static List<Card> ToDo;
        public static List<Card> InProgress;
        public static List<Card> Done;

        public Board()
        {
            ToDo = DefaultToDoCards();
            InProgress = DefaultInProgressCard();
            Done = DefaultDoneCards();
        }
        public static List<Card> DefaultToDoCards()
        {
            return new List<Card>(){
                new Card("Title - 1","Content -1",1,Size.S)
            };
        }
        public static List<Card> DefaultInProgressCard()
        {
            return new List<Card>(){
                new Card("Title - 2","Content -2",2,Size.M)
            };
        }
        public static List<Card> DefaultDoneCards()
        {
            return new List<Card>(){
                new Card("Title - 3","Content -3",3,Size.XL)
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo
{
    class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int MemberID { get; set; }
        public Size Size { get; set; }

        public Card()
        {

        }
        public Card(string title, string content, int memberID, Size size)
        {
            this.Title = title;
            this.Content = content;
            this.MemberID = memberID;
            this.Size = size;
        }


    }
}
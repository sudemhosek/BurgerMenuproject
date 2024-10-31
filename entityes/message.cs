using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project2BurgerMenu.entityes
{
    public class message
    { public int messageId { get;set; }
    public string Title { get;set; }
     public string SenderEmail { get;set; }
     public string ReceiverEmaiL { get;set; }
     public string Contet { get;set; }
     public DateTime SendDate { get;set; }
     public bool Isread { get;set; }
    }
}
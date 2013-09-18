using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace BellordPlants.Cloud.MVC.Models
{
    public class Question
    {
        public virtual int QuestionId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual List<Answer> Answers { get; set; }

    } 
}
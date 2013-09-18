using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;



namespace BellordPlants.Cloud.MVC.Models
{
    public class Answer
    {
        public virtual int AnswerId { get; set; }
        public virtual int QuestionId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string Title { get; set; }
        public virtual string AnswerText { get; set; }
    } 
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWebUI.DTOs.TestimonialDto
{
    public class CreateTestimonialDto
    {
        public string Fullname { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Text.Encodings.Web;

        public class HelloController : Controller
        {
            // 
            // GET: /HelloWorld/

            public string Index()
            {
                return "This is my default action...";
            }

        // 
        // GET: /HelloWorld/Welcome/ 

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
    }

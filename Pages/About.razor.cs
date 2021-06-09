using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace DevPage.Pages
{
    public partial class About
    {
        private PageContent _pageContent;

        private string _paragraph1 = "My name is Dino Lozina, an engineer from Split, Croatia. I have been programming for more than ten years. As an electrical engineer my first professional programming experience was with Programmable Logic Controllers (PLC). We where machine builders, and we did all of our machine programming.";

        private string _paragraph2 = "After four years my interest shifted towards robots, instead of machines I have started to program robots in various industries. (Warehouse automation, glass container and automotive industry). I have become proficient at programming robots and developing machine vision software. After many projects all over the world I have decided to return home to Split. That was a big change for me because there was not much opportunities for robot and machine vision engineer, so I had to reinvent myself as software engineer.";

        private string _paragraph3 = "It was a challenge.I knew that my problem solving skills are good and also I had years of programming with high level languages “under my belt“ (remember I started with low level languages) but still you have to adapt to certain way of work that software companies provide. Last couple of years I am developing solutions for Enterprise Content Management (ECM) and I have teaching positions at University of Split where I teach Robotics and Machine Vision.";

        private string _paragraph4 = "I am very happy that I had such rich career and success in various engineering roles. Goal for the future is to constantly improve as an engineer, share my knowledge and experience.";

        private string _leftSidebarTitle2 = "Engineer (definition)";

        private string _leftSidebarContent2 = "Engineers, as practitioners of engineering, are professionals who invent, design, analyze, build and test machines, complex systems, structures, gadgets and materials to fulfill functional objectives and requirements while considering the limitations imposed by practicality, regulation, safety and cost.";

        public class PageContent
        {
            public DateTime Date { get; set; }

            public string Title { get; set; }

            public string Content { get; set; }
        }
    }
}

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
        [Inject]
        public HttpClient HttpClient { get; set; }

        private PageContent _pageContent;

        //private string _pageText = "My name is Dino Lozina, an engineer from Split, Croatia. I have been programming for more than ten years. As an electrical engineer my first professional programming experience was with Programmable Logic Controllers (PLC). We where machine builders, and we did all of our machine programming. After four years my interest shifted towards robots, instead of machines I have started to program robots in various industries. (Warehouse automation, glass container and automotive industry). I have become proficient at programming robots and developing machine vision software. After many projects all over the world I have decided to return home to Split. That was a big change for me because there was not much opportunities for robot and machine vision engineer, so I had to reinvent myself as software engineer. It was a challenge. I knew that my problem solving skills are good and also I had years of programming with high level languages “under my belt“ (remember i started with low level languages) but still you have to adapt to certain way of work that software companies provide. Last couple of years I am developing solutions for Enterprise Content Management (ECM) and I have teaching positions at University of Split where I teach Robotics and Machine vision. I am very happy that I had such rich career and success in various engineering roles. Goal for the future is to constantly improve as an engineer, share my knowledge and experience.";

        private string _paragraph1 = "My name is Dino Lozina, an engineer from Split, Croatia. I have been programming for more than ten years. As an electrical engineer my first professional programming experience was with Programmable Logic Controllers (PLC). We where machine builders, and we did all of our machine programming.";

        private string _paragraph2 = "After four years my interest shifted towards robots, instead of machines I have started to program robots in various industries. (Warehouse automation, glass container and automotive industry). I have become proficient at programming robots and developing machine vision software. After many projects all over the world I have decided to return home to Split. That was a big change for me because there was not much opportunities for robot and machine vision engineer, so I had to reinvent myself as software engineer.";

        private string _paragraph3 = "It was a challenge.I knew that my problem solving skills are good and also I had years of programming with high level languages “under my belt“ (remember i started with low level languages) but still you have to adapt to certain way of work that software companies provide. Last couple of years I am developing solutions for Enterprise Content Management(ECM) and I have teaching positions at University of Split where I teach Robotics and Machine vision.";

        private string _paragraph4 = "I am very happy that I had such rich career and success in various engineering roles. Goal for the future is to constantly improve as an engineer, share my knowledge and experience.";

        //private string _leftSidebarTitle = "What is This?";

        //private string _leftSidebarContent = "This is my test page where I test.NET 5 and Blazor WASM, I play around with this relatively new frontend framework. It would be really cool to write whole application (front and back) with C# code. I would also love to see where Web Assembly (abbreviated Wasm) will lead us in context of web development. Interesting times are ahead of us.";
        
        protected override async Task OnInitializedAsync()
        {
            _pageContent = await HttpClient.GetFromJsonAsync<PageContent>("data/about.json");
        }

        public class PageContent
        {
            public DateTime Date { get; set; }

            public string Title { get; set; }

            public string Content { get; set; }
        }
    }
}

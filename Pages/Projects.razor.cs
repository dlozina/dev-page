using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevPage.Pages
{
    public partial class Projects
    {
        // Project No.1 - IT project
        private string _projectTitle1 = "Podravka, Koprivnica, Croatia";
        private string _projectTime1 = "12/2020 - today";
        private string _projectWork1 = "Development, debugging, testing, user support";
        private string _projectTech1 = "C#, ASP.NET, WPF, jQuery, SQL (ORM)";
        private string _projectList11 = "Automation of payment order processes";
        private string _projectList12 = "Developing email service that gathers relevant data";
        private string _projectList13 = "Developing UI settings for consultant and testing teams";
        private string _projectList14 = "Frontend development in .NET framework (WPF)";

        // Project No.2 - IT project
        private string _projectTitle2 = "Financial Agency (Fina), Zagreb, Croatia";
        private string _projectTime2 = "04/2020 - 12/2020";
        private string _projectWork2 = "Development, debugging, testing, user support";
        private string _projectTech2 = "C#, ASP.NET, jQuery, SQL (ORM) , various OCR engines (Nicomsoft, Abbyy,Tesseract), machine learning(.NET ML), OpenCV, Camunda";
        private string _projectList21 = "Automation of payment order processes";
        private string _projectList22 = "Developing selfhost API";
        private string _projectList23 = "Using machine learning to classify types of documents";
        private string _projectList24 = "Using machine vision to classify types of documents";
        private string _projectList25 = "Using OCR (Optical character recognition) to gather data from documents";
        private string _projectList26 = "Using machine learning to correct wrong data points";
        private string _projectList27 = "Frontend development (HTML, CSS, jQuery)";

        // Project No.3 - IT project
        private string _projectTitle3 = "Vienna Insurance Group, Zagreb, Croatia";
        private string _projectTime3 = "10/2019 - 04/2020";
        private string _projectWork3 = "Development, debugging, testing, user support";
        private string _projectTech3= "C#, ASP.NET, jQuery, SQL (ORM), machine learning (.NET ML), OpenCV, Camunda";
        private string _projectList31 = "Development of mobile application that automates insurance purchase";
        private string _projectList32 = "Development of server-side services";
        private string _projectList33 = "Using machine learning to classify types of documents";
        private string _projectList34 = "Developing UI settings for consultant and testing teams";
        private string _projectList35 = "Frontend development (HTML, CSS, jQuery)";

        // Project No.4 - IT project
        private string _projectTitle4 = "University of Split, Split, Croatia";
        private string _projectTime4 = "10/2019 – today";
        private string _projectWork4 = "Conception, specification, development, implementation";
        private string _projectTech4 = "Python, machine learning, machine vision, Open CV";
        private string _projectList41 = "Solving robot pick and place tasks with machine vision";
        private string _projectList42 = "Migration from .NET to Python and OpenCV";
        private string _projectList43 = "Using open-source ML libraries";
        private string _projectList44 = "Preparing documentation for lectures";

        // Project No.5 - IT project
        private string _projectTitle5 = "University of Split, Split, Croatia";
        private string _projectTime5 = "10/2018 – 10/2019";
        private string _projectWork5 = "Conception, development, validation";
        private string _projectTech5 = "C#, machine learning, machine vision, Halcon, robot programing";
        private string _projectList51 = "Solving robot pick and place tasks with machine vision";
        private string _projectList52 = "Conception of a machine vision software";
        private string _projectList53 = "Using machine learning for object recognition";
        private string _projectList54 = "Programing advanced robot functions";
        private string _projectList55 = "Frontend development in .NET framework (WPF)";
        private string _projectList56 = "Preparing documentation for lectures";

        // Project No.6 - IT project
        private string _projectTitle6 = "Unior , Zreče, Slovenia";
        private string _projectTime6 = "01/2019 - 09/2019";
        private string _projectWork6 = "Team lead, product owner, conception, development, validation, commissioning";
        private string _projectTech6 = "C#, WPF, SQL, machine vision, Halcon";
        private string _projectList61 = "Development of an application for measurement of production workpieces(Pincers)";
        private string _projectList62 = "Conception of a machine vision software";
        private string _projectList63 = "Saving and managing data (SQL)";
        private string _projectList64 = "Frontend development in .NET framework (WPF)";
        private string _projectList65 = "Team management of 3 people";

        // Project No.7 - IT project
        private string _projectTitle7 = "Omco, Hum na Sutli, Croatia";
        private string _projectTime7 = "04/2018 - 01/2019";
        private string _projectWork7 = "Team lead, product owner, conception, development, validation, commissioning";
        private string _projectTech7 = "C#, WPF, SQL, machine learning, machine vision, Halcon";
        private string _projectList71 = "Development of an application for measurement of production workpieces (Bottle molds)";
        private string _projectList72 = "Conception of a software for control of measurement machine";
        private string _projectList73 = "Gathering data from third-party machines";
        private string _projectList74 = "Saving and managing data (SQL)";
        private string _projectList75 = "Development of algorithm for production workpieces correction";
        private string _projectList76 = "Frontend development in .NET framework (WPF)";
        private string _projectList77 = "Team management of 3 people";

        // Project No.8 - IT project
        private string _projectTitle8 = "Omco, Hum na Sutli, Croatia";
        private string _projectTime8 = "08/2017 - 04/2018";
        private string _projectWork8 = "Team lead, product owner conception, prototype development, validation, commissioning";
        private string _projectTech8 = "C#, WPF, SQL, machine learning, machine vision, Halcon";
        private string _projectList81 = "Developing prototype application for robot pick and place applications";
        private string _projectList82 = "Developing machine vision software";
        private string _projectList83 = "Frontend development in .NET framework (WPF)";
        private string _projectList84 = "Saving and managing data (SQL)";
        private string _projectList85 = "Team management of 3 people";

        // Project No.9 - Engineering project
        private string _projectTitle9 = "Walmart, Mebane, North Carolina, USA";
        private string _projectTime9 = "10/2016 - 6/2017";
        private string _projectWork9 = "Team lead, development, validation, commissioning";
        private string _projectTech9 = "Robot Programming, machine vision programming, PLC programming";
        private string _projectList91 = "Development of warehouse automation solutions";
        private string _projectList92 = "Developing software for robots";
        private string _projectList93 = "Setting up robot vision systems";
        private string _projectList94 = "Team management of 5 - 10 people";

        // Project No.10 - Engineering project
        private string _projectTitle10 = "Coca-Cola, Oceanside, California, USA";
        private string _projectTime10 = "01/2016 - 10/2016";
        private string _projectWork10 = "Development, validation, commissioning";
        private string _projectTech10 = "PLC programming, Robot programming, commissioning";
        private string _projectList101 = "Development of warehouse automation solutions";
        private string _projectList102 = "Ensuring that the different protocols (security, I/O validation, etc.) has been performed";
        private string _projectList103 = "Making sure that the industrial network is functional";
        private string _projectList104 = "Controlling and ensuring the quality of installation and the final adjustments";

        // Project No.11 - Engineering project
        private string _projectTitle11 = "Seaonics, Alesund, Norway";
        private string _projectTime11 = "01/2014 - 12/2015";
        private string _projectWork11 = "Conception, development, validation, commissioning";
        private string _projectTech11 = "PLC programming, HMI programming, electrical drawings design";
        private string _projectList111 = "Conception of a software for control of Electric Double Mooring Winch 100kN";
        private string _projectList112 = "Conception of electrical drawings";
        private string _projectList113 = "Setting up machine radio control";
        private string _projectList114 = "Testing equipment on site";

        // Project No.12 - Engineering project
        private string _projectTitle12 = "AdriaWinch, Split, Croatia";
        private string _projectTime12 = "03/2013 - 01/2014";
        private string _projectWork12 = "Conception, prototype development, validation, testing, commissioning";
        private string _projectTech12 = "PLC programming, HMI programming, electrical drawings design";
        private string _projectList121 = "Conception of a software for control of Electric Towing Winch 40kN";
        private string _projectList122 = "Conception of electrical drawings";
        private string _projectList123 = "Implementing safety features based on force measurement";
        private string _projectList124 = "Developing software for HMI (Human machine interface)";
        private string _projectList125 = "Testing safety features of equipment";

        // Project No.13 - Engineering project
        private string _projectTitle13 = "AdriaWinch, Split, Croatia";
        private string _projectTime13 = "03/2012 - 03/2013";
        private string _projectWork13 = "Conception, prototype development, validation, testing, commissioning";
        private string _projectTech13 = "PLC programming, HMI programming, electrical drawings design";
        private string _projectList131 = "Conception of a software for control of Anchor-mooring winch 66K3";
        private string _projectList132 = "Developing software for automatic anchor mooring";
        private string _projectList133 = "Developing software for HMI (Human machine interface)";
        private string _projectList134 = "Testing safety features of equipment";

        // Project No.14 - Engineering project
        private string _projectTitle14 = "LASMEA (Laboratoire des Sciences et Materiaux pur L’Electronique et D’Automatique), Clermon - Ferrand, France";
        private string _projectTime14 = "03/2011 - 06/2011";
        private string _projectWork14 = "Master thesis research";
        private string _projectTech14 = "FEKO";
        private string _projectList141 = "Research for master thesis";
        private string _projectList142 = "Collaboration between French colleges and home institution (FESB)";
        private string _projectList143 = "Published paper on subject (Transmission Line Theory approach used on Typical Power Line Communication Structures)";
    }
}

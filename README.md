ASP.NET MVC Sandbox
===================
This project will contain a toy MVC website using ASP.Net vNext. First, install the basics as described in [Graeme Christie's blog post](http://graemechristie.github.io/graemechristie/blog/2014/05/26/asp-dot-net-vnext-on-osx-and-linux/).

This worked quite flawlessly for me, just [Nowin](https://github.com/Bobris/Nowin) I had to build myself and place somewhere where kpm could find it.

After having set this up, run the following command to initialize the packages:

    kpm restore -s https://www.myget.org/F/aspnetvnext/

If everything went well, you can now start the website by typing

    k web

It will be accessible under http://localhost:8080


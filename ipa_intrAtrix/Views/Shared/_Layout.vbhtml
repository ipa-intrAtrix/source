﻿<!DOCTYPE html>
<html lang="de">
    <head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta charset="utf-8" />
        <title>@ViewData("Title") - intrAtrix</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")
    </head>
    <body>
        <header>
            <div class="content-wrapper">
                <div class="float-left">
                    <p class="site-title">@Html.ActionLink("Ihr Logo hier einfügen", "Index", "Home")</p>
                </div>
                <div class="float-right">
                    <section id="login">
                       Hallo <span class="username">@User.Identity.Name</span>!
                    </section>
                    <nav>
                        <ul id="menu">
                            <li>@Html.ActionLink("Startseite", "Index", "Home")</li>
                            <li>@Html.ActionLink("Kundennetzwerke", "Index", "Customer")</li>
                            <li>@Html.ActionLink(User.Identity.Name, "Index", "User")</li>
                            <li>@Html.ActionLink("Lieferantenangaben", "Index", "Provider")</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </header>
        <div id="body">
            @RenderSection("featured", required:=false)
            <section class="content-wrapper main-content clear-fix">
                @RenderBody()
            </section>
        </div>
        <footer>
            <div class="content-wrapper">
                <div class="float-left">
                    <p>&copy; @DateTime.Now.Year - Meine ASP.NET MVC-Anwendung</p>
                </div>
            </div>
        </footer>

        @Scripts.Render("~/bundles/jquery")
        @RenderSection("scripts", required:=False)
    </body>
</html>

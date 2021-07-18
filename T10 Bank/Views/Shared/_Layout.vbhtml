<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="~/Content/animate.css">
    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>

<body>
    <div class="navbar navbar-inverse navbar-fixed-top header">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @*@Html.ActionLink("Nome do aplicativo", "Index", "Home", New With { .area = "" }, New With { .class = "navbar-brand" })*@
                <div>
                    <a class="header-logo" href="/Home/Index"></a>
                </div>
            </div>
            <div class="navbar-collapse collapse header-menu">
                <ul class="nav navbar-nav">
                    <li><a href="#home">Home</a></li>
                    <li><a href="#sobrenos">Sobre nós</a></li>
                    <li><a href="#">Serviços</a></li>
                    <li><a href="#">Portólio</a></li>
                    <li><a href="#">Contato</a></li>
                    @*<li>@Html.ActionLink("Sobre nós", "Index", "Home")</li>
                        <li>@Html.ActionLink("Sobre", "About", "Home")</li>
                        <li>@Html.ActionLink("Contato", "Contact", "Home")</li>*@
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            @*<p>&copy; @DateTime.Now.Year</p>*@
        </footer>
    </div>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/wow/0.1.12/wow.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js" type="text/javascript"></script>
    <script src="~/Scripts/site.js"></script>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
﻿@Code
    ViewData("Title") = "Benutzerdaten"
End Code


@section featured
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>@ViewData("Title").</h1>
                <h2>@ViewData("Message")</h2>
            </hgroup>
            <p>
                Hier sind alle Benutzerdaten zu finden. 
            </p>
        </div>
    </section>
End Section

<h3>Inhalt der der Benutzerdaten Seite.</h3>
<ol class="round">
    <li></li>
</ol>

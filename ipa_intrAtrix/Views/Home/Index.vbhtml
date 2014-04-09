@Code
    ViewData("Title") = "Startseite"
End Code

@section featured
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>@ViewData("Title").</h1>
                <h2>@ViewData("Message")</h2>
            </hgroup>
            <p>
                Dies ist die Startseite von intrAtrix.
            </p>
        </div>
    </section>
End Section

<h3>Inhalt der Intranet Seite.</h3>
<ol class="round">
    <li class="one">
        <h5>@User.Identity.Name</h5>
        Ist der Benutzer authentifiziert -> @User.Identity.IsAuthenticated
    </li>

    <li class="two">
        <h5>Kundennetzwerkdaten</h5>
        Hier ist eine kleine Zusammenfassung der Kundennetzwerkdaten.
    </li>

    <li class="three">
        <h5>Lieferantenangaben</h5>
        Hier ist eine kleine Zusammenfassung der Lieferantenangaben. 
    </li>
</ol>

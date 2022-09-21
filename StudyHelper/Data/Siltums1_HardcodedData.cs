using Microsoft.Maui;
using StudyHelper.Models;
using System.Text;

namespace StudyHelper.Data
{
    public class Siltums1_HardcodedData
    {
        static string q1 = $"Kas ir izolēta termodinamiska sistēma?";
        static string a1 = $"Kas Par izolētu sauc tādu termodinamisko sistēmu, kurai nav mijiedarbības ar apkārtējo vidi.{StaticVariableLibary.needsNewLine}(9.lpp.)";
        static string q2 = $"Kas ir neizolēta termodinamiska sistēma?";
        static string a2 = $"Par neizolētu sauc tādu termodinamisko sistēmu, kas mijiedarbojas ar apkārtējo vidi.{StaticVariableLibary.needsNewLine}(9.lpp.)";
        static string q3 = $"Kas ir noslēgta termodinamiska sistēma?";
        static string a3 = $"Ja mijiedarbības rezultātā ar apkārtējo vidi termodinamiskās sistēmas ķermeņu skaits, t.i., sistēmas lielums (masa), nemainās, sistēmu sauc par noslēgtu.{StaticVariableLibary.needsNewLine}(10.lpp.)";
        static string q4 = $"Kas ir vaļēja termodinamiska sistēma?";
        static string a4 = $"Ja mijiedarbības rezultātā ar apkārtējo vidi termodinamiskās sistēmas ķermeņu skaits, t.i., sistēmas lielums (masa), mainās, sistēmu sauc par nenoslēgtu jeb vaļēju.{StaticVariableLibary.needsNewLine}(10.lpp.)";
        static string q5 = $"Ko raksturo ķermeņa temperatūra?";
        static string a5 = $"Temperatūra raksturo termodinamiskās sistēmas un tās sastāvdaļu siltuma pakāpi.{StaticVariableLibary.needsNewLine}(11.lpp.)";
        static string q6 = $"Uzrakstīt skaitlisko sakarību starp absolūto un Celsija skalas temperatūru";
        static string a6 = $"1K = 1{StaticVariableLibary.degreeChar}C; T=t+273.15{StaticVariableLibary.degreeChar}C{StaticVariableLibary.needsNewLine}(11.lpp.)";
        static string q7 = $"Definēt spiedienu";
        static string a7 = $"Spiediens ir spēks, ar kādu darba ķermenis iedarbojas uz virsmas laukuma vienību{StaticVariableLibary.needsNewLine}(12.lpp.)";
        static string q8 = $"Kādas ir spiediena mērvienības SI un citās sistēmās?";
        static string a8 = $"N/m{StaticVariableLibary.supscript2} jeb Pa (paskāls). Normālā fiziskā atmosfēra (bar?), tehniskā atmosfēra (at), mm H{StaticVariableLibary.subscript2}O staba, mm Hg staba{StaticVariableLibary.needsNewLine}(12.lpp.)";
        static string q9 = $"Kas ir īpatnējais tilpums, tā mērvienība?";
        static string a9 = $"Īpatnējais tilpums ir darba vielas viena masas kilograma ieņemtais tilpums, ko pieņemts apzīmēt ar {StaticVariableLibary.smallNu_specificVolumeChar}. {StaticVariableLibary.smallNu_specificVolumeChar}=V/M, kur V - darba vielas kopējais tilpums (m{StaticVariableLibary.supscript3}), M - darba vielas masa (kg).{StaticVariableLibary.needsNewLine}(14.-15.lpp.)";
        static string q10 = $"Kas ir darba ķermeņa normālie apstākļi?";
        static string a10 = $"T=273.15K jeb t=0{StaticVariableLibary.degreeChar}C; spiediens p=101325 Pa jeb 1 fizikālā atmosfēra (bar).{StaticVariableLibary.needsNewLine}(15.lpp.)";
        static string q11 = $"Kas ir entalpija, tās mērvienība?";
        static string a11 = $"Termodinamiskās sistēmas iekšējās enerģijas un tilpuma enerģijas summa. Entalpiju apzīmē ar h, mērvienība J/kg vai kJ/kg.{StaticVariableLibary.needsNewLine}(16.lpp.)";
        static string q12 = $"Kāda ir entropijas mērvienība?";
        static string a12 = $"J/K vai kJ/K{StaticVariableLibary.needsNewLine}(17.lpp.)";
        static string q13 = $"Kas ir termodinamiskais process?";
        static string a13 = $"Termodinamiskās sistēmas stāvokļa (parametru) secīga maiņa laikā.{StaticVariableLibary.needsNewLine}(17.lpp.)";
        static string q14 = $"Kas ir ideāla gāze?";
        static string a14 = $"Par ideālu gāzi sauc tādu gāzes modeli, kas sastāv no absolūti elestīgām daļiņām (molekulām), kuru tilpumu var neievērot un starp kurām nedarbojas savstarpējie pievilkšanās spēki.{StaticVariableLibary.needsNewLine}(19.lpp.)";
        static string q15 = $"Uzrakstīt gāzes stāvokļa vienādojumu ideālai gāzei";
        static string a15 = $"F(T, p, {StaticVariableLibary.smallNu_specificVolumeChar}) = 0. T - temperatūra K (kelvins); p - spiediens Pa (paskāls), {StaticVariableLibary.smallNu_specificVolumeChar} - īpatnējais tilpums m{StaticVariableLibary.supscript3}/kg.{StaticVariableLibary.needsNewLine}(19.lpp.)";
        static string q16 = $"Kas ir gāzes individuālā konstante, mērvienība?";
        static string a16 = $"Gāzes individuālā konstante ir darba daudzums, ko padara viens kilograms gāzes izplešoties, ja tās temperatūra paaugstinās par vienu grādu. Apzīmē ar R, mērvienība - J/Kg*K.{StaticVariableLibary.needsNewLine}(21.lpp.)";
        static string q17 = $"Kas ir īpatnējā siltumietilpība, mērvienība?";
        static string a17 = $"Par vielas īpatnējo siltumietilpību (siltumkapacitāti) sauc siltuma daudzumu, kas jāpievada vielas masas vienībai, lai tās temperatūru paagustinātu par vienu kelvinu (grādu).{StaticVariableLibary.needsNewLine}(26.lpp.)";
        static string q18 = $"Kādi ir īpatnējās siltumietilpības veidi, mērvienības?";
        static string a18 = $"1) masas īpatnējā siltumietilpība, apzīmē ar c, mērvienība(dimensija) - J/(kg*K);{StaticVariableLibary.needsNewLine}2) tilpuma īpatnējā siltumietilpība, apzīmē ar c', mērvienība (dimensija) - J/(m{StaticVariableLibary.supscript3}*K);{StaticVariableLibary.needsNewLine}3) molārā īpatnējā siltumietilpība, apzīmē ar c{StaticVariableLibary.needsSubscriptStart}{StaticVariableLibary.smallMuChar}{StaticVariableLibary.needsSubscriptEnd}, mērvienība (dimensija) - J/(mol*K).{StaticVariableLibary.needsNewLine}(26.lpp.)";
        static string q19 = $"Pirmais termodinamikas likums";
        static string a19 = $"Pirmais termodinamikas likums ir enerģjas nezūdamības likuma atsevišķs gadījums, kas iegūts, piemērojot to enerģijas pārejas siltuma un darba formām. Siltums un darbs jāuzskata par enerģijas pārejas un pastāvēšanas veidiem termodinamiskā procesa gaidā. Šie enerģijas veidi noteiktos apstākļos var pārveidoties cits citā. Saskaņā ar enerģijas nezūdamības likumu visu enerģijas veidu summa izolētā sistēmā paliek bez izmaiņām.{StaticVariableLibary.needsNewLine}(28.lpp.)";
        static string q20 = $"Nosaukt termodinamikas pamatprocesus";
        static string a20 = $"1) izohorais (izohoriskais) process, kur {StaticVariableLibary.smallNu_specificVolumeChar}=const ({StaticVariableLibary.smallNu_specificVolumeChar} - īpatnējais tilpums);{StaticVariableLibary.needsNewLine}2) izobārais (izbāriskais) process, kur p=const (p - spiediens);{StaticVariableLibary.needsNewLine}3) izotermais (izotermiskais) process, kur T=const (T - temperatūra kelvinos);{StaticVariableLibary.needsNewLine}4)adiabātais (adiabātiskais) process, kur q=const (q - īpatnējā siltumietilpība);{StaticVariableLibary.needsNewLine}5) politropais (politropiskais) rocess, kas ir vispārināts termodinamiskais process.{StaticVariableLibary.needsNewLine}(34.lpp.)";
        static string q21 = $"Kas ir termodinamiskais cikls?";
        static string a21 = $"Par termodinamisko ciklu sauc secīgi notiekošu termodinamisko procesu kopu, kuru gaitā darba ķermenis, maintot savu stāvokli, atkal atgriežas sākotnējā stāvokolī, t.i., iegūst sākotnējā stāvokļa parametrus. Dažreiz termodinamisko ciklu sauc arī par noslēgtu vai ciklisku procesu.{StaticVariableLibary.needsNewLine}(45.lpp.)";
        static string q22 = $"Uzzīmēt Karno ciklu p-{StaticVariableLibary.smallNu_specificVolumeChar} koordinātu sistēmā. Paskaidrot līknes?";
        static string a22 = $"Skatīt zīmējumu (uzzīmēt protams savu).{StaticVariableLibary.needsNewLine}Procesā 1-2 gāzei siltumu izotermi pievada{StaticVariableLibary.needsNewLine}procesā 2-3 darba ķermenis turpina adiabāti izplesties{StaticVariableLibary.needsNewLine}procesā 3-4 siltumu izotermi novada, saspiežot darba ķermeni{StaticVariableLibary.needsNewLine}procesā 4-1 turpina adiabātu darba ķermeņa saspiešanu.{StaticVariableLibary.needsNewLine}(47.lpp.)";
        static byte[] z22 = Siltums1Resources.Siltums1Res.karno_cikls;
        static string q23 = $"Kā izsaka Karno cikla lietderības koeficientu?";
        static string a23 = $"{StaticVariableLibary.smallEtaChar}{StaticVariableLibary.subscript_t}{StaticVariableLibary.supscript_leftParenthesis}{StaticVariableLibary.supscript_k}{StaticVariableLibary.supscript_rightParenthesis}=(q{StaticVariableLibary.subscript1}-q{StaticVariableLibary.subscript2})/q{StaticVariableLibary.subscript2}=(RT{StaticVariableLibary.primeChar}ln({StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript2}/{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript1})-RT{StaticVariableLibary.doublePrimeChar}ln({StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript3}/{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript4}))/(RT{StaticVariableLibary.primeChar}ln({StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript2}/{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript1})); saīsinot {StaticVariableLibary.smallEtaChar}{StaticVariableLibary.subscript_t}{StaticVariableLibary.supscript_leftParenthesis}{StaticVariableLibary.supscript_k}{StaticVariableLibary.supscript_rightParenthesis}=(T{StaticVariableLibary.primeChar}-T{StaticVariableLibary.doublePrimeChar})/T{StaticVariableLibary.primeChar}=1-(T{StaticVariableLibary.doublePrimeChar}/T{StaticVariableLibary.primeChar}){StaticVariableLibary.needsNewLine}(48.lpp.)";// 
        static string q24 = $"Uzrakstīt kādu no otrā termodinamikas likuma formulējumiem";
        static string a24 = $"1. Siltuma pārveidošanai darbā nepieciešama temperatūru diference starp siltuma avotu un dzesētāju (S. Karno, 1824. gads).{StaticVariableLibary.needsNewLine}2. Siltums pats no sevis bez papildu enerģijas patēriņa nevar pāriet no aukstāka ķermeņa uz siltāku ķermeni (R. Klauziuss, 1850. gads).{StaticVariableLibary.needsNewLine}3. Nav iespējams izveidot tādu periodiski darbojošos dzinēju, ura darbības rezultāts būtu vienīgi sistēmas zemākās temperatūras siltuma pārvēršana darbā (V. Tomsons, 1851. gads).{StaticVariableLibary.needsNewLine}4. Cikliskā procesā visu pievadīto siltumu nevar pārvērst mehāniskajā enerģijā (M. Planks, 1892. gads).{StaticVariableLibary.needsNewLine}5. Visi procesi dabā patvaļīgi noris virzienā no stāvokļa ar mazāku varbūtību uz stāvokli ar lielāku varbūtību (L. Bolcmanis).{StaticVariableLibary.needsNewLine}(50.-51.lpp.)";
        static string q25 = $"Kas ir ekserģija?";
        static string a25 = $"Par ekserģiju E sauc to termodinamiskās sistēmas enerģijas daļu, ko var pārvērst mehāniskajā vai elektriskajā enerģijā, ja sistēma atgriezenisku procesu veidā nonāk līdzsvarā ar apkārtējo vidi. Šādi atgriezeniskie procesi ir adiabāta un izoterma.{StaticVariableLibary.needsNewLine}Tātad ekserģija ir maksimālais darbs, ko var paveikt termodinamiskā sistēma.{StaticVariableLibary.needsNewLine}(57.lpp.)";
        static string q26 = $"Ar ko atšķiras reāla gāze no ideālas?";
        static string a26 = $"Reālās gāzes no ideālajām gāzēm atšķiras galvenokārt ar to, ka molekulām ir masa un tilpums un starp tām pastāv mijiedarbības spēki.{StaticVariableLibary.needsNewLine}(65.lpp.)";
        static string q27 = $"Uzrakstīt Van der Vālsa vienādojumu reālai gāzei un paskaidrot tā locekļus";
        static string a27 = $"Van der Vālsa vienādojums -> (p+(a/{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.supscript2}))({StaticVariableLibary.smallNu_specificVolumeChar}-b)=RT.{StaticVariableLibary.needsNewLine}Tā kā reālo gāu molekulām ir tilums, tas it kā samazina gāzes aizņemto brīvo tilpumu {StaticVariableLibary.smallNu_specificVolumeChar} par kādu lielumu b.{StaticVariableLibary.needsNewLine}Starp gāzes molekulām darbojās savstarpējie pievilkšanās spēki, kas it kā palielina ārējo spiedienu. Van der Vālss pierādija, ka šo papildu spiedienu var izteikt kā a/{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.supscript2}, kur a - koeficients.{StaticVariableLibary.needsNewLine}Tātad p+a/{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.supscript2} ir gāzes spiediens + papildus spiediens, kas rodās no pievilkšanās spēkiem un {StaticVariableLibary.smallNu_specificVolumeChar}-b ir gāzes īpatnējais 'brīvais' tilpums no kura atņem gāzu molekulu tilpumu. R - gāzes individuālā konstante, T - gāzes temperatūra. (65.-66.lpp.)";
        static string q28 = $"Kas ir ūdens trīskāršais punkts?";
        static string a28 = $"Noteiktā spiedienā un temperatūrā iestājas līdzsvars starp ūdens cieto fāzi (ledu), šķidrumu un tvaiku. (69.lpp.)";
        static string q29 = $"Kas ir pārkarsēts tvaiks?";
        static string a29 = $"Pārkarsēts tvaiks ir tvaiks, kura temperatūra sāk paaugstināties virs iztvaikošanas (piesātināšanas) temperatūras. (70.lpp.)";
        static string q30 = $"Kas ir mitrs tvaiks?";
        static string a30 = $"Mitrs tvaiks ir tvaiks kas satur gan sausu tvaiku, gan tvaikā nepārvērsa šķidruma daļiņas, t. i., visa šķidrā fāze nav pilnīgi iztvaikojusi un tvaika temperatūra atbilst vārīšanās temperatūrai dotajā spiedienā. (70.lpp.)";
        static string q31 = $"Kas ir sauss piesātināts tvaiks?";
        static string a31 = $"Sauss piesātināts tvaiks ir tvaiks kas nesatur tvaikā nepārvērsta šķitruma daļiņas, t. i., visa šķidrā fāze ir pilnībā iztvaikojusi un tvaika temperatūra atbilst vārīšanās temperatūrai dotajā spiedienā. (70.lpp.)";
        static string q32 = $"Kādai vielas fāzei piemīt īpatnējie tilpumi, ko apzīmē ar: {StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.primeChar}, {StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.doublePrimeChar}, {StaticVariableLibary.smallNu_specificVolumeChar}, {StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscriptX}?";
        static string a32 = $"{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.primeChar} - īpatnējais tilpums verdošam šķidrumam;{StaticVariableLibary.needsNewLine}{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.doublePrimeChar} - īpatnējais tilpums sausam piesātinātam tvaikam;{StaticVariableLibary.needsNewLine}{StaticVariableLibary.smallNu_specificVolumeChar} - īpatnējais tilpums pārkarsētam tvaikam;{StaticVariableLibary.needsNewLine}{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscriptX} - īpatnējais tilpums mitram tvaikam.{StaticVariableLibary.needsNewLine}(71.lpp.)";
        static string q33 = $"Kas ir ūdens iztvaikošanas siltums?";
        static string a33 = $"Iztvaikošanas siltums ir siltuma daudzumsr, kas jāpievada 1kg šķidruma (ūdens) piesātināšanas stāvoklī, lai to pilnīgi pārvērstu sausā piesātinātā tvaikā. r - J/kg. (73.lpp.)";
        static string q34 = $"Kas veido ūdens iztvaikošanas siltumu?";
        static string a34 = $"Ūdens iztvaikošanas siltumu (r) veido iekšējās iztvaikošanas siltuma ({StaticVariableLibary.smallRhoChar}) un ārējā iztvaikošanas siltuma ({StaticVariableLibary.smallPsiChar}) summa.{StaticVariableLibary.needsNewLine}r=u{StaticVariableLibary.doublePrimeChar}-u{StaticVariableLibary.primeChar}+p({StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.doublePrimeChar}-{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.primeChar} jeb r={StaticVariableLibary.smallRhoChar}+{StaticVariableLibary.smallPsiChar}). (73.lpp.)";
        static string q35 = $"Kāds ir un kam ir proporcionāls darbs un iekšējās enerģijas izmaiņa tvaikam izohoriskā procesā?";
        static string a35 = $"Izohoriskā procesā tilpums nemainās ({StaticVariableLibary.smallNu_specificVolumeChar}=const), tāpēc darbs netiek veikts (l=0). Visu procesa siltumu patērē iekšējās enerģijas izmaiņai.{StaticVariableLibary.needsNewLine}l=0; q=u{StaticVariableLibary.subscript2}-u{StaticVariableLibary.subscript1}; u=h-p{StaticVariableLibary.smallNu_specificVolumeChar}; q=h{StaticVariableLibary.subscript2}-p{StaticVariableLibary.subscript2}{StaticVariableLibary.smallNu_specificVolumeChar}-(h{StaticVariableLibary.subscript1}-p{StaticVariableLibary.subscript1}{StaticVariableLibary.smallNu_specificVolumeChar}).{StaticVariableLibary.needsNewLine}l - padarītais darbs, u - iekšējā enerģija, q - pievadītais siltums, h - entalpija, p - spiediens, {StaticVariableLibary.smallNu_specificVolumeChar} - īpatnējais tilpums. (76.lpp.?)";
        static string q36 = $"Kāds ir un kam ir proporcionāls darbs un iekšējās enerģijas izmaiņa tvaikam adiabātiskā procesā";
        static string a36 = $"Tvaika pastrādātais darbs -> l=-(u{StaticVariableLibary.subscript2}-u{StaticVariableLibary.subscript1})=h{StaticVariableLibary.subscript1}-h{StaticVariableLibary.subscript2}-(p{StaticVariableLibary.subscript1}{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript1}-p{StaticVariableLibary.subscript2}{StaticVariableLibary.smallNu_specificVolumeChar}{StaticVariableLibary.subscript2}). l - darbs, u - iekšējā enerģija, h - entalpija, p - spiediens, {StaticVariableLibary.smallNu_specificVolumeChar} - īpatnējais tilpums.{StaticVariableLibary.needsNewLine}Darbs ir tieši pretējs iekšējo enerģiju starpībai. Iekšējā enerģija..... (79.lpp.)";
        static string q37 = $"Kas ir rasas punkts mitram gaisam?";
        static string a37 = $"Temperatūru, kurā gaisā esošais ūdens tvaiks kļūst piesātināts, sauc par rasas punktu. (80. lpp.)";
        static string q38 = $"Kas ir gaisa relatīvais mitrums, mērvienība?";
        static string a38 = $"Par gaisa relatīvo mitrumu {StaticVariableLibary.smallPhiChar} sauc absolūtā mitruma {StaticVariableLibary.smallRhoChar}{StaticVariableLibary.needsSubscriptStart}d{StaticVariableLibary.needsSubscriptEnd} attiecību pret maksimāli iespējamo gaisa mitrumu {StaticVariableLibary.smallRhoChar}{StaticVariableLibary.needsSubscriptStart}s{StaticVariableLibary.needsSubscriptEnd} attiecīgajā temperatūrā un spiedienā, tas ir, {StaticVariableLibary.smallPhiChar} = {StaticVariableLibary.smallRhoChar}{StaticVariableLibary.needsSubscriptStart}d{StaticVariableLibary.needsSubscriptEnd}/{StaticVariableLibary.smallRhoChar}{StaticVariableLibary.needsSubscriptStart}s{StaticVariableLibary.needsSubscriptEnd}.{StaticVariableLibary.needsNewLine}Izsakot {StaticVariableLibary.smallRhoChar}{StaticVariableLibary.needsSubscriptStart}d{StaticVariableLibary.needsSubscriptEnd} un {StaticVariableLibary.smallRhoChar}{StaticVariableLibary.needsSubscriptStart}s{StaticVariableLibary.needsSubscriptEnd} no gāzu stāvokļa vienādojuma, iegūst {StaticVariableLibary.smallPhiChar} = p{StaticVariableLibary.needsSubscriptStart}d{StaticVariableLibary.needsSubscriptEnd}/p{StaticVariableLibary.needsSubscriptStart}s{StaticVariableLibary.needsSubscriptEnd}.{StaticVariableLibary.needsNewLine}Mērvienības nav, {StaticVariableLibary.smallPhiChar} ir koeficients. (80.-81. lpp.)";
        static string q39 = $"Kas ir gaisa absolūtais mitrums, mērvienība?";
        static string a39 = $"Par absolūto gaisa mitrumu sauc kilogramos izteiktu ūdens tvaika masu vienā kubikmetrā gaisa. Tādejāti tas ir gaisā esošā ūdens tvaika blīvums {StaticVariableLibary.smallRhoChar}{StaticVariableLibary.needsSubscriptStart}d{StaticVariableLibary.needsSubscriptEnd} (kg/m{StaticVariableLibary.supscript3}). (80. lpp.)";
        static string q40 = $"Kas ir gaisa mitruma saturs, mērvienība?";
        static string a40 = $"Gaisa mitruma saturs ir gaisā esošā ūdens tvaika masas attiecība pret sausā gaisa masu. Citiem vārdiem sakot, mitruma saturs ir ūdens tvaika masa vienā kilogrammā sausa gaisa. Mitruma saturu, izsakot kg, parasti apzīmē ar x.{StaticVariableLibary.needsNewLine}Mitruma saturs ir koeficients, nav mērvienības.{StaticVariableLibary.needsNewLine}Apzīmē ar d, ja izsaka kā g/kg. (81. lpp.)";
        static string q41 = $"Ko sauc par gāzi tvaika-gāzes maisījumā?";
        static string a41 = $"Par gāzi sauc tās vielas, kas dotajos apstākļos nevar kondesēties. (no pierakstiem)";
        static string q42 = $"Ko sauc par tvaiku tvaika-gāzes maisījumā?";
        static string a42 = $"Par tvaiku sauc tās vielas, kas var dotajos apstākļos var kondensēties. (no pierakstiem)";
        static string q43 = $"Uzzīmēt kompresora ideālo ciklu, paskaidrot līknes";
        static string a43 = $"-> Process 1-2. Gāzes saspiešana, kas var norisināties:{StaticVariableLibary.needsNewLine}- 1-2{StaticVariableLibary.primeChar} - adiabātiski{StaticVariableLibary.needsNewLine}- 1-2{StaticVariableLibary.doublePrimeChar} - politropiski{StaticVariableLibary.needsNewLine}- 1-2{StaticVariableLibary.triplePrimeChar} - izotermiski.{StaticVariableLibary.needsNewLine}-> Process 2-3. Izobāriska gāzes izplūde.{StaticVariableLibary.needsNewLine}-> Process 3-4. Virzuļa virziena maiņa.{StaticVariableLibary.needsNewLine}-> Process 4-1. Izobāriska gāzes ieplūde/iesūkšana.{StaticVariableLibary.needsNewLine}(97. lpp. + no pierakstiem)";
        static byte[] z43 = Siltums1Resources.Siltums1Res.kompresora_cikls;
        static string q44 = $"Uzzīmēt iekšdedzes motora Otto ciklu p-{StaticVariableLibary.smallNu_specificVolumeChar} koordinātu sistēmā, paskaidrot līknes";
        static string a44 = $"-> Process 1-2. Adiabātiska darba vielas saspiešana.{StaticVariableLibary.needsNewLine}-> Process 2-3. Izohoriska siltuma pievadīšana sadedzinot degvielu.{StaticVariableLibary.needsNewLine}-> Process 3-4. Adiabātiska izplešanās - darba gājiens.{StaticVariableLibary.needsNewLine}-> Process 4-1. Izohoriska siltuma aizvadīšana (izpūšot dūmgāzes, ievelkot vēsāku gaisu).{StaticVariableLibary.needsNewLine}(99.-101. lpp. + no pierakstiem)";
        static byte[] z44 = Siltums1Resources.Siltums1Res.oto_cikls;
        static string q45 = $"Uzzīmēt iekšdedzes motora Dīzeļa ciklu p-{StaticVariableLibary.smallNu_specificVolumeChar} koordinātu sistēmā, paskaidrot līknes";
        static string a45 = $"-> Process 1-2. Adiabātiska gaisa saspiešana (ievērojami pieagu temperatūra).{StaticVariableLibary.needsNewLine}-> Process 2-3. Izotermiska siltuma pievadīšana (cilindrā iesmidzina degvielu, kura sadeg).{StaticVariableLibary.needsNewLine}-> Process 3-4. Gāze izplešas un veic darba gājienu.{StaticVariableLibary.needsNewLine}-> Process 4-1. Izohoriska siltuma aizvadīšana (izpūš dūmgāzes, iesūc gaisu).{StaticVariableLibary.needsNewLine}(101.-102. lpp. + no pierakstiem)";
        static byte[] z45 = Siltums1Resources.Siltums1Res.dizela_cikls;
        static string q46 = $"Uzzīmēt gāzes turbīnas ciklu p-{StaticVariableLibary.smallNu_specificVolumeChar} koordinātu sistēmā un paskaidrot līknes";
        static string a46 = $"-> Process 1-2. Adiabātiska vielas saspiešana.{StaticVariableLibary.needsNewLine}-> Process 2-3. Izobāriska siltuma pievadīšana (vaļējā degkamerā sadeg degviela).{StaticVariableLibary.needsNewLine}-> Process 3-4. Adiabātiska izplešanās (dūmgāzes izplūst no degšanas kameras uz turbīnas lāpstiņām).{StaticVariableLibary.needsNewLine}-> Process 4-1. Izobāriska siltuma aizvadīšana.{StaticVariableLibary.needsNewLine}(105-106. lpp. + no pierakstiem)";
        static byte[] z46 = Siltums1Resources.Siltums1Res.gazu_turbinu_cikls;
        static string q47 = $"Uzzīmēt pamatcikla tvaika iekārtas shēmu, nosaukt tās sastāvdaļas";
        static string a47 = $"BS - barošanas sūknis; E - Ekonomaizers; EĢ - elektroģenerators; Iztv - iztvaicētājs; K - dzesētājs-kondensators; KS - kondensāta sūknis; KT - kondensāta tvertne; P - pārkarsētājs; TT - tvaika turbīna.{StaticVariableLibary.needsNewLine}(107-109. lpp. + no pierakstiem)";
        static byte[] z47 = Siltums1Resources.Siltums1Res.tvaiku_iekartas_pamatcikla_shema;
        static string q48 = $"Uzzīmēt tvaika iekārtas pamatciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a48 = $"-> Process 3-4. Kondensāts tiek padots/iesūknēts katlā-ekonomaizerā.{StaticVariableLibary.needsNewLine}-> Process 4-5. Tas uzsilst līdz iztvaikošanas temperatūrai.{StaticVariableLibary.needsNewLine}-> Process 5-6. Notiek iztvaikošana iztvaicētājā.{StaticVariableLibary.needsNewLine}-> Process 6-1. Tvaiks tiek pārkarsēts, tas ir, tiek pacelta tvaika temperatūra.{StaticVariableLibary.needsNewLine}-> Process 1-2. Tvaiks nonāk tvaika turbīnā un griež elektroģeneratoru.{StaticVariableLibary.needsNewLine}-> Process 2-3. Kondensātorā tvaiks atdod pārpalikušo siltumu un kondensējas. Un tiek novadīts uz kondensāta tvertni.{StaticVariableLibary.needsNewLine}(107-109. lpp. + no pierakstiem)";
        static byte[] z48 = Siltums1Resources.Siltums1Res.tvaiku_iekartas_pamatcikls;
        static string q49 = $"Uzzīmēt tvaika iekārtas ciklu ar atkārtotu tvaika pārkarsēšanu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a49 = $"-> Process 3-4. Kondensāts tiek padots/iesūknēts katlā-ekonomaizerā.{StaticVariableLibary.needsNewLine}-> Process 4-5. Tas uzsilst līdz iztvaikošanas temperatūrai.{StaticVariableLibary.needsNewLine}-> Process 5-6. Notiek iztvaikošana iztvaicētājā.{StaticVariableLibary.needsNewLine}-> Process 6-1. Tvaiks tiek pārkarsēts, tas ir, tiek pacelta tvaika temperatūra.{StaticVariableLibary.needsNewLine}-> Process 1-2{StaticVariableLibary.primeChar}. Tvaiks nonāk tvaika turbīnā un griež elektroģeneratoru.{StaticVariableLibary.needsNewLine}-> Process 2{StaticVariableLibary.primeChar}-1{StaticVariableLibary.primeChar}. Tvaiks tiek pārkarsēts.{StaticVariableLibary.needsNewLine}-> Process 1{StaticVariableLibary.primeChar}-2. Tvaiks nonāk tvaika turbīnā un griež elektroģeneratoru.{StaticVariableLibary.needsNewLine}-> Process 2-3. Kondensātorā tvaiks atdod pārpalikušo siltumu un kondensējas. Un tiek novadīts uz kondensāta tvertni.{StaticVariableLibary.needsNewLine}(111-113. lpp. + no pierakstiem)";
        static byte[] z49 = Siltums1Resources.Siltums1Res.tvaiku_iekartas_cikls_ar_atkartotu_parkarsesanu;
        static string q50 = $"Uzzīmēt saldēšanas iekārtas ideālo ciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a50 = $"-> Process 4-1. Aukstuma aģents ar zemu temperatūru ieplūst saldēšanas kamerā un uzņem siltumu no dzesējamā materiāla.{StaticVariableLibary.needsNewLine}-> Process 1-2. Aukstuma aģents tiek adiabātiski saspiests kompresorā, pieaug temperatūra.{StaticVariableLibary.needsNewLine}-> Process 2-3. Aukstuma aģents izotermiski dzesētājā atdod siltumu apkārtējai videi.{StaticVariableLibary.needsNewLine}-> Process 3-4. Aukstuma aģents adiabātiski izplešas detanderā, samazinās spiediens un temperatūra.{StaticVariableLibary.needsNewLine}";
        static byte[] z50 = Siltums1Resources.Siltums1Res.idealais_saldesanas_iekartas_cikls;
        static string q51 = $"Uzzīmēt gāzes cikla saldēšanas iekārtas shēmu, nosaukt sastāvdaļas";
        static string a51 = $"SK - saldēšanas kamera; K - kompresors; Dz - dzesētājs; Dt - detanders (izplešanās trauks). (121.-123. lpp. + no pierakstiem)";
        static byte[] z51 = Siltums1Resources.Siltums1Res.saldesanas_iekartas_gazes_cikla_shema;
        static string q52 = $"Uzzīmēt saldēšanas iekārtas gāzes ciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a52 = $"-> Process 1-2. Notiek gāzes adiabāta saspiešana kompresorā.{StaticVariableLibary.needsNewLine}-> Process 2-3. Izobārā procesā dzesētājā novada siltumu q{StaticVariableLibary.subscript1}. Siltuma novadīšanu gāzei nevar veikt izotermi, kā tas ir Karno ciklā, bet process noris izobāri, pazeminoties gāzes temperatūrai.{StaticVariableLibary.needsNewLine}-> Process 3-4. Gāzes detanderā adiabāti izplešas, tā rezultātā pazeminās gāzes spiediens un temperatūra.{StaticVariableLibary.needsNewLine}-> Process 4-1. Atdzisusī gāze siltumapaiņas aparātā - saldēšanas kamerā - uzņem siltumu no dzesējamās vides (izobāra), un tās temperatūra paaugstinās.{StaticVariableLibary.needsNewLine}(122. lpp.)";
        static byte[] z52 = Siltums1Resources.Siltums1Res.saldesanas_iekartas_gazes_cikls;
        static string q53 = $"Uzzīmēt tvaika cikla saldēšanas iekārtas shēmu, nosaukt sastāvdaļas";
        static string a53 = $"K - kompresors; Kd - kondensators; Dz - dzesētājs; Dr - droselēšanas ventilis (drosele); Sk - saldēšanas kamera.{StaticVariableLibary.needsNewLine}(123. lpp.)";
        static byte[] z53 = Siltums1Resources.Siltums1Res.saldesanas_iekartas_tvaika_cikla_shema;
        static string q54 = $"Uzzīmēt saldēšanas iekārtas tvaika ciklu T-s koordinātu sistēmā, paskaidrot līknes";
        static string a54 = $"-> Process 4-1. Aukstuma aģents šķidrā veidā ieplūst saldēšanas kamerā, uzņem siltumu no dzesējamā materiāla un iztvaiko.{StaticVariableLibary.needsNewLine}-> Process 1-2. Aukstuma aģenta tvaiki tiek saspiesti, pieaug spiediens un temperatūra.{StaticVariableLibary.needsNewLine}-> Process 2-2{StaticVariableLibary.primeChar}. Aukstuma aģents atdod siltumu kondensatorā, atdziest un kondensējas.{StaticVariableLibary.needsNewLine}-> Process 2{StaticVariableLibary.doublePrimeChar}-3. Aukstuma aģents atdod siltumu dzesētājā, samazinās temperatūra.{StaticVariableLibary.needsNewLine}-> Process 3-4. Droselē aukstuma aģentam ievērojami samazinās spiediens un temperatūra.{StaticVariableLibary.needsNewLine}(123.-123. lpp. + no pierakstiem)";
        static byte[] z54 = Siltums1Resources.Siltums1Res.saldesanas_iekartas_tvaika_cikls;
        static string q55 = $"Paskaidrot saldēšanas iekārtas termodinamiskos darbības principus";
        static string a55 = $"Gāze ar kompresora palīdzību tiek saspiesta, tā palielinot spiedienu un samazinot temperatūru. Tad tiek aizvadīta uz dzesēšanas kameru, kur tiek uzņemts siltums, ko pēc tam izvada ārā.{StaticVariableLibary.needsNewLine}(no pierakstiem)";
        static string q56 = $"Uzzīmēt siltumsūkņa shēmu, nosaukt sastāvdaļas";
        static string a56 = $"1 - kompresors; 2 - kondensators; 3 - droselēšanas ventīlis (drosele); 4 - iztvaikotājs; 5 - dabas siltuma avots; 6 - siltumnesēja cirkulācijas sūknis; 7 - siltumtīkls; 8 - cirkulācijas sūknis; 9 - patērētāji.{StaticVariableLibary.needsNewLine}(no pierakstiem)";
        static byte[] z56 = Siltums1Resources.Siltums1Res.siltuma_sukna_shema;
        static string q57 = $"Paskaidrot siltumsūkņa termodinamiskos darbības principus";
        static string a57 = $"Siltumsūknis darbojas pēc apgrieztā termodinamiskā cikla (apgrieztā Karno cikla), tas saņem siltumu no apkārtējās vides, ciklā patērē darbu un nodod tālāk siltumu.{StaticVariableLibary.needsNewLine}(šis liekas tāds, nepilnīgs...ņemts no pierakstiem)";
        static string q58 = $"Kas ir siltumapmaiņa?";
        static string a58 = $"Par siltumapmaiņu sauc siltuma enerģijas izplatīšanās (pārneses) procesu ķermeņos (ciets, šķidrs, gāzveida) vai ķermeņu kopā - sistēmā. (134. lpp.)";
        static string q59 = $"Kādos veidos notiek siltumapmaiņa?";
        static string a59 = $"-> Siltumvadīšana{StaticVariableLibary.needsNewLine}-> Siltuma konvekcija{StaticVariableLibary.needsNewLine}-> Starošanās{StaticVariableLibary.needsNewLine}(134. lpp.)";
        static string q60 = $"Kā tiek pārnesta siltuma enerģija vadīšanā?";
        static string a60 = $"Siltumvadīšanā enerģija tiek ārnesta, saskaroties molekulām un atomiem, kā arī difundējot vielas mikrodaļiņām (molekulām, atomiem un elektroniem).{StaticVariableLibary.needsNewLine}(134. lpp.)";
        static string q61 = $"Kā tiek pārnesta siltuma enerģija konvekcijā?";
        static string a61 = $"Siltuma konvekcija notiek tikai gāzēs un šķidrumos, kad pārvietojas un sajaucas lielas molekulu grupas resp. šķidruma vai gāzes daļas ar dažādām temperatūrām.{StaticVariableLibary.needsNewLine}(134. lpp.)";
        static string q62 = $"Kā tiek pārnesta siltuma enerģija starošanā?";
        static string a62 = $"Siltuma starošanā viens ķermenis daļu iekšējās enerģijas atdod citam ķermenim ar elektromagnētisko viļņu starpniecību.{StaticVariableLibary.needsNewLine}(135. lpp.)";
        static string q63 = $"Kas ir temperatūras lauks?";
        static string a63 = $"Temperatūras vērtību kopumu telpā (ķermenī) jebkurā laika momentā sauc par temperatūras lauku.{StaticVariableLibary.needsNewLine}(135. lpp.)";
        static string q64 = $"Kas ir stacionārs un nestacionārs temperatūras lauks?";
        static string a64 = $"Ja temperatūra atsevišķos ķermeņa punktos laikā nemainās, temperatūras lauks ir stacionārs; ja turpretim temperatūra mainās, lauks ir stacionārs.{StaticVariableLibary.needsNewLine}(135. lpp.)";
        static string q65 = $"Ko raksturo temperatūras gradients?";
        static string a65 = $"Temperatūras pieauguma ātrumu raksturo temperatūras gradients.{StaticVariableLibary.needsNewLine}(136. lpp.)";
        static string q66 = $"Kas ir siltumvadītspējas koeficients?";
        static string a66 = $"Siltumvadītspējas koeficients {StaticVariableLibary.smallLambda} raksturo vielas spēju vadīt siltumu un skaitliski izsaka to siltuma daudzumu, kas 1 sekundē izplūst caur 1m{StaticVariableLibary.supscript2} lielu virsmu, ja temperatūras gradients ir 1 K/m.{StaticVariableLibary.needsNewLine}(137. lpp.)";
        static string q67 = $"Uzskaitīt sistēmu viennozīmīguma nosacījumus";
        static string a67 = $"1) Ģeometriskie nosacījumi;{StaticVariableLibary.needsNewLine}2) fizikālie nosacījumi;{StaticVariableLibary.needsNewLine}3) laika nosacījumi jeb sākumnosacījumi;{StaticVariableLibary.needsNewLine}4) pirmās kārtas robežnosacījumi;{StaticVariableLibary.needsNewLine}5) otrās kārtas robežnosacījumi;{StaticVariableLibary.needsNewLine}6) trešās kārtas robežnosacījumi.";
        static string q68 = $"Uzrakstīt Ņūtona vienādojumu siltuma plūsmas aprēķinam";
        static string a68 = $"{StaticVariableLibary.capitalPhiChar}={StaticVariableLibary.smallAlphaChar}S(T{StaticVariableLibary.subscript1}-T{StaticVariableLibary.subscript2}), kur T{StaticVariableLibary.subscript1} un T{StaticVariableLibary.subscript2} - sienas virsmas un siltumnesēja temperatūras; {StaticVariableLibary.smallAlphaChar} - siltumatdeves koeficients; {StaticVariableLibary.capitalPhiChar} - siltuma plūsma.{StaticVariableLibary.needsNewLine}(142. lpp.)";
        static string q69 = $"Kas ir siltumatdeves koeficients?";
        static string a69 = $"{StaticVariableLibary.smallAlphaChar} - siltumatdeves koeficients (W/(m{StaticVariableLibary.supscript2}K)), kas rāda, kāds ir siltuma daudzums laika vienībā no sienas virsmas 1m{StaticVariableLibary.supscript2} tiek atdots šķidrumam (vai otrādi - no šķidruma sienai), ja temperatūru starpība starp šķidrumu un sienas virsmu ir 1K.{StaticVariableLibary.needsNewLine}(142. lpp.)";
        static string q70 = $"Uzzīmēt temperatūras sadalījumu siltumam plūstot caur plāksni pie trešās kārtas robežnosacījumiem";
        static string a70 = $"";
        static byte[] z70 = Siltums1Resources.Siltums1Res.temperaturas_sadalijums_caur_vienu_plaksni;
        static string q71 = $"Kā var aprēķināt siltumpārejas koeficientu daudzslāņu plāksnei?";
        static string a71 = $"Siltuma plūsmas blīvumu siltumpāreju caur daudzkārtu sienu aprēķina pēc tādas pašas izteiksmes kā vienkārtas sienas gadījumā, tikai siltumpārejas koeficienta izteiksmē vienas termiskās pertestības vietā jāievieto visu kārtu termisko pretestību summa {StaticVariableLibary.captialSigmaChar}({StaticVariableLibary.smallDeltaChar}{StaticVariableLibary.needsSubscriptStart}i{StaticVariableLibary.needsSubscriptEnd}/{StaticVariableLibary.smallLambda}{StaticVariableLibary.needsSubscriptStart}i{StaticVariableLibary.needsSubscriptEnd}). Tad:";
        static byte[] z71 = Siltums1Resources.Siltums1Res.a71;
        static string q72 = $"Uzzīmēt temperatūras sadalījumu siltumam plūstot caur cilindriskas caurules sienu pie trešās kārtas robežnosacījumiem";
        static string a72 = $"";
        static byte[] z72 = Siltums1Resources.Siltums1Res.a72;
        static string q73 = $"Kas ir cauruļvadu siltumizolācijas kritiskais biezums?";
        static string a73 = $"";
        static byte[] z73 = Siltums1Resources.Siltums1Res.a73;
        static string q74 = $"Kas ir apribojuma koeficients?";
        static string a74 = $"Izsaka sildvirsmas ribotās puses pilnā laukuma attiecību pret sienas gludās puses laukumu.{StaticVariableLibary.needsNewLine}m=S{StaticVariableLibary.subscript2}/S{StaticVariableLibary.subscript1}.{StaticVariableLibary.needsNewLine}(160. lpp.)";
        static string q75 = $"Uzzīmēt temperatūras sadalījuma līkni ķermenī virsmas tuvumā tam dziestot no vienas puses";
        static string a75 = $"";
        static byte[] z75 = Siltums1Resources.Siltums1Res.a75;
        static string q76 = $"Uzzīmēt temperatūras sadalījuma līkni plāksnē tai dziestot no abām pusēm";
        static string a76 = $"";
        static byte[] z76 = Siltums1Resources.Siltums1Res.a76;
        static string q77 = $"Kāda ir līdzības skaitļu būtība?";
        static string a77 = $"Tie piešķir konkrētu viennozīmīgumu.{StaticVariableLibary.needsNewLine}Divi procesi ir līdzīgi, ja: 1) tie ir kvalitatīvi vienādi; 2) atbilstoši lielumi ir saistīti ar vienādiem līdzības skaitļiem.{StaticVariableLibary.needsNewLine}(no pierakstiem)";
        static string q78 = $"Kas ir brīvā konvekcija?";
        static string a78 = $"Brīvā konvekcija rodas atsevišķu daļiņu nevienmērīgas sasilšanas dēļ. Daļiņas, kas atrodas tuvāk karstajai sienai, sasilts, to blīvums samazinās un tās ceļas uz augšu.{StaticVariableLibary.needsNewLine}(177. lpp.)";
        static string q79 = $"Kas ir piespiedu konvekcija?";
        static string a79 = $"Piespiedu konvekcijā šķidrums vai gāze pārvietojas spiedumu starpības dēļ. Spiedienu starpību var izraisīt vējš, šķidruma līmeņu starpība, ventilatori, sūkņi.{StaticVariableLibary.needsNewLine}(177. lpp.)";
        static string q80 = $"Izskaidrot, kā notiek siltumpārnese laminārā plūsmā";
        static string a80 = $"Laminārā plūsmā siltums tiek nodots tikai vadīšanas ceļā.";
        static string q81 = $"Izskaidrot, kā notiek siltumpārnese turbulentā plūsmā";
        static string a81 = $"Siltumatdeve notiek gan konvekcijas gan vadīšanas ceļā.";
        static string q82 = $"Uzzīmēt siltumatdeves koeficienta izmaiņas grafiku atkarībā no augstuma brīvai konvekcijai gar vertikālu sienu";
        static string a82 = $"";
        static byte[] z82 = Siltums1Resources.Siltums1Res.a82;
        static string q83 = $"Kas ir kodolveida kondensācija?";
        static string a83 = $"Ja šķidrums neslapina virsmu vai slapina to tikai daļēji, tad ir pilienu kondensācija (sauc arī par kondensāciju rasas veidā), kad kondensāts rodas atsevišķu pilienu veidā. {StaticVariableLibary.needsNewLine}(189. lpp.)";
        static string q84 = $"Kas ir plēves veida kondensācija?";
        static string a84 = $"Ja šķidrums slapina sienas virsmu, tad tā ir plēves veida kondensācija.{StaticVariableLibary.needsNewLine}(189. lpp.)";
        static string q85 = $"Kas ir kodolveida iztvaikošana?";
        static string a85 = $"Maksimālā šķidruma temperatūra būs pie trauka, resp., sildvirsmas karstajām sienām. Uz šīs virsmas ir atsevišķi sienas negludumi, bedrītes, pielipuši gaisa pūslīši, katlakmens un putekļi, kas veido iztvaikošanas centrus. Šeit rodas atsevišķie tvaika burbulīši - pūslīši, kuri atraujas no sienas un ceļas uz augšu, izraisot šķidrumā intensīvu konvekciju. Tā ir pūslīšu jeb kodolveida iztvaikošana. {StaticVariableLibary.needsNewLine}(188. lpp.)";
        static string q86 = $"Kas ir plēves veida iztvaikošana?";
        static string a86 = $"Siltumatdeve un līdz ar to arī iztvaikošanas intensitāte palielinās līdz ar sildvirsmas temperatūras paaugstināšanos. Arvien varāk tvaika pūslīšu veidojas uz sienas virsmas, kamēr pūslīši saplūst un sāk veidot tvaika plēvi. Pūslīšu jeb kodolveida iztvaikošana pāriet plēves veida iztvaikošanā.{StaticVariableLibary.needsNewLine}(188. lpp.)";
        static string q87 = $"Cik ir A, R, D absolūti melnam ķermenim?";
        static string a87 = $"A=1, R=0, D=0.{StaticVariableLibary.needsNewLine}(199. lpp.)";
        static string q88 = $"Cik ir A, R, D absolūti caurspīdīgam ķermenim?";
        static string a88 = $"A=0, R=0, D=1.{StaticVariableLibary.needsNewLine}(199. lpp.)";
        static string q89 = $"Cik ir A, R, D absolūti baltam ķermenim?";
        static string a89 = $"A=0, R=1, D=0.{StaticVariableLibary.needsNewLine}(199. lpp.)";
        static string q90 = $"Kas ir integrālais starojums?";
        static string a90 = $"Par integrālo sauc summāro starojumu visos viļņu garumos - no {StaticVariableLibary.smallLambda}=0 līdz {StaticVariableLibary.smallLambda}={StaticVariableLibary.smallInfinity}.{StaticVariableLibary.needsNewLine}(199. lpp.)";
        static string q91 = $"Kas ir monohromatiskais starojums?";
        static string a91 = $"Par monohromatisko sauc starojumu šaurā viļņu intervālā: no {StaticVariableLibary.smallLambda} līdz {StaticVariableLibary.smallLambda}+d{StaticVariableLibary.smallLambda}.{StaticVariableLibary.needsNewLine}(199. lpp.)";
        static string q92 = $"Kas ir starojuma plūsmas blīvums (intensitāte)?";
        static string a92 = $"Starojuma plūsmu, kas iet caur (vai krīt uz) virsmas 1m{StaticVariableLibary.supscript2}, sauc par starojuma plūsmas blībumu jeb intensitāti E(W/m{StaticVariableLibary.supscript2}).{StaticVariableLibary.needsNewLine}(199. lpp.)";
        static string q93 = $"Paskaidrot Planka likuma būtību siltumstarošanā";
        static string a93 = $"Šis likums izsaka absolūti melna ķermeņa siltuma starojuma sadalījumu pie dažādiem viļņu garumiem atkarībā no temperatūras.{StaticVariableLibary.needsNewLine}(200. lpp. + no pierakstiem)";
        static string q94 = $"Paskaidrot Vjēna (Vīna) likuma būtību siltumstarošanā";
        static string a94 = $"Paaugstinot temperatūru viļņu garums pie kura ir maksimālais starojums samazinās.{StaticVariableLibary.needsNewLine}(200. lpp. + no pierakstiem)";
        static string q95 = $"Paskaidrot Stefana-Bolcmaņa likuma būtību siltumstarošanā";
        static string a95 = $"Izsaka absolūti melna ķermeņa intensitāti atkarībā no temperatūras. (200.-201. lpp. + no pierakstiem)";
        static string q96 = $"Paskaidrot otrā Kirhofa likuma būtību siltumstarošanā";
        static string a96 = $"Izstarotās enerģijas attiecība pret absorbcijas koeficientu vienā un tajā pašā temperatūrā visiem ķermeņiem ir vienāda.{StaticVariableLibary.needsNewLine}(201.-202.lpp. + no pierakstiem)";
        static string q97 = $"Paskaidrot Lamberta likuma būtību siltumstarošanā";
        static string a97 = $"Pieaugot leņķim {StaticVariableLibary.smallOmegaChar}, starojuma intensitāte samazinās.{StaticVariableLibary.needsNewLine}(202.-203. lpp. + no pierakstiem)";
        static string q98 = $"Uzzīmēt skici, kas paskaidro ķermeņu savstarpējo apstarošanos";
        static string a98 = $"";
        static byte[] z98 = Siltums1Resources.Siltums1Res.a98;

        public static List<QuestionAndAnswerModel> GetQnAList()
        {
            var res = new List<QuestionAndAnswerModel>()
            {
                new QuestionAndAnswerModel(){ QuestionId = 1, Question = q1, Answer = a1, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 2, Question = q2, Answer = a2, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 3, Question = q3, Answer = a3, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 4, Question = q4, Answer = a4, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 5, Question = q5, Answer = a5, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 6, Question = q6, Answer = a6, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 7, Question = q7, Answer = a7, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 8, Question = q8, Answer = a8, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 9, Question = q9, Answer = a9, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 10, Question = q10, Answer = a10, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 11, Question = q11, Answer = a11, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 12, Question = q12, Answer = a12, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 13, Question = q13, Answer = a13, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 14, Question = q14, Answer = a14, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 15, Question = q15, Answer = a15, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 16, Question = q16, Answer = a16, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 17, Question = q17, Answer = a17, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 18, Question = q18, Answer = a18, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 19, Question = q19, Answer = a19, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 20, Question = q20, Answer = a20, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 21, Question = q21, Answer = a21, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 22, Question = q22, Answer = a22, AnswerImage = z22, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 23, Question = q23, Answer = a23, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 24, Question = q24, Answer = a24, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 25, Question = q25, Answer = a25, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 26, Question = q26, Answer = a26, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 27, Question = q27, Answer = a27, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 28, Question = q28, Answer = a28, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 29, Question = q29, Answer = a29, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 30, Question = q30, Answer = a30, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 31, Question = q31, Answer = a31, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 32, Question = q32, Answer = a32, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 33, Question = q33, Answer = a33, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 34, Question = q34, Answer = a34, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 35, Question = q35, Answer = a35, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 36, Question = q36, Answer = a36, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 37, Question = q37, Answer = a37, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 38, Question = q38, Answer = a38, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 39, Question = q39, Answer = a39, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 40, Question = q40, Answer = a40, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 41, Question = q41, Answer = a41, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 42, Question = q42, Answer = a42, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 43, Question = q43, Answer = a43, AnswerImage = z43, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 44, Question = q44, Answer = a44, AnswerImage = z44, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 45, Question = q45, Answer = a45, AnswerImage = z45, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 46, Question = q46, Answer = a46, AnswerImage = z46, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 47, Question = q47, Answer = a47, AnswerImage = z47, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 48, Question = q48, Answer = a48, AnswerImage = z48, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 49, Question = q49, Answer = a49, AnswerImage = z49, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 50, Question = q50, Answer = a50, AnswerImage = z50, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 51, Question = q51, Answer = a51, AnswerImage = z51, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 52, Question = q52, Answer = a52, AnswerImage = z52, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 53, Question = q53, Answer = a53, AnswerImage = z53, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 54, Question = q54, Answer = a54, AnswerImage = z54, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 55, Question = q55, Answer = a55, AnswerImage = StaticVariableLibary.zBlank, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 56, Question = q56, Answer = a56, AnswerImage = z56, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 57, Question = q57, Answer = a57, AnswerImage = StaticVariableLibary.zBlank, Points = 2 },
                new QuestionAndAnswerModel(){ QuestionId = 58, Question = q58, Answer = a58, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 59, Question = q59, Answer = a59, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 60, Question = q60, Answer = a60, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 61, Question = q61, Answer = a61, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 62, Question = q62, Answer = a62, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 63, Question = q63, Answer = a63, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 64, Question = q64, Answer = a64, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 65, Question = q65, Answer = a65, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 66, Question = q66, Answer = a66, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 67, Question = q67, Answer = a67, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 68, Question = q68, Answer = a68, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 69, Question = q69, Answer = a69, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 70, Question = q70, Answer = a70, AnswerImage = z70, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 71, Question = q71, Answer = a71, AnswerImage = z71, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 72, Question = q72, Answer = a72, AnswerImage = z72, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 73, Question = q73, Answer = a73, AnswerImage = z73, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 74, Question = q74, Answer = a74, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 75, Question = q75, Answer = a75, AnswerImage = z75, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 76, Question = q76, Answer = a76, AnswerImage = z76, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 77, Question = q77, Answer = a77, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 78, Question = q78, Answer = a78, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 79, Question = q79, Answer = a79, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 80, Question = q80, Answer = a80, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 81, Question = q81, Answer = a81, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 82, Question = q82, Answer = a82, AnswerImage = z82, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 83, Question = q83, Answer = a83, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 84, Question = q84, Answer = a84, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 85, Question = q85, Answer = a85, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 86, Question = q86, Answer = a86, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 87, Question = q87, Answer = a87, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 88, Question = q88, Answer = a88, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 89, Question = q89, Answer = a89, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 90, Question = q90, Answer = a90, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 91, Question = q91, Answer = a91, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 92, Question = q92, Answer = a92, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 93, Question = q93, Answer = a93, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 94, Question = q94, Answer = a94, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 95, Question = q95, Answer = a95, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 96, Question = q96, Answer = a96, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 97, Question = q97, Answer = a97, AnswerImage = StaticVariableLibary.zBlank, Points = 1 },
                new QuestionAndAnswerModel(){ QuestionId = 98, Question = q98, Answer = a98, AnswerImage = z98, Points = 1 },
            };

            return res;
        }
    }
}

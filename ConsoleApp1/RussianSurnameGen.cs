﻿using PlugBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class RussianSurnameGen : Generator
    {
        List<string> surnames;

        public RussianSurnameGen(List<string> surnames)
        {
            this.surnames = surnames;
        }

        public RussianSurnameGen()
        {
            this.surnames = new List<string> { "Abakumov", "Abalyshev", "Abarnikov", "Abdulov", "Abramov", "Abramovich", "Adaksin", "Afanasyev", "Afonin", "Agafonov", "Agapov", "Ageykin", "Agliullin", "Akhremenko", "Akinfeev", "Aksakov", "Aksenchuk", "Aksyonov", "Akulov", "Alenin", "Alexandrov", "Alexeyev", "Aleyev", "Alistratov", "Aliyev", "Alliluyev", "Alogrin", "Alyokhin", "Amaliyev", "Amelin", "Aminev", "Ananyev", "Anasenko", "Andreyev", "Andreyushkin", "Andronikov", "Andropov", "Andryukhin", "Anikanov", "Anikin", "Anishin", "Anisimov", "Ankudinov", "Annikov", "Anokhin", "Anoshkin", "Anosov", "Anrep", "Antakov", "Antakov", "Antipin", "Antipov", "Antonov", "Antonovich", "Apalkov", "Aptekar", "Ardankin", "Arefyev", "Aristarkhov", "Aristov", "Arsenyev", "Arshavin", "Artamonov", "Artemyev", "Artyomov", "Arzamastsev", "Aslakhanov", "Aslanov", "Aspidov", "Assonov", "Astafyev", "Astakhov", "Astankov", "Avandeyev", "Avdeyev", "Avdonin", "Averin", "Averyanov", "Avilov", "Avtukhov", "Ayushiyev", "Azarov", "Azhikelyamov", "Azhishchenkov", "Babanin", "Babatyev", "Babichev", "Babikov", "Babkin", "Baburin", "Babykin", "Bagrov", "Bakrylov", "Balabanov", "Balakhnov", "Balakin", "Balakirev", "Balandin", "Balashov", "Balsunov", "Baltabev", "Banin", "Baranov", "Baranovsky", "Barbolin", "Barentsev", "Barinov", "Barinov", "Barkov", "Barndyk", "Barsukov", "Baryshev", "Baryshnikov", "Batishchev", "Batrutdinov", "Bazanov", "Bazarov", "Bazhanov", "Bazhenov", "Bazin", "Bebchuk", "Bebnev", "Bekhterev", "Belevich", "Beliberdiyev", "Belikov", "Belinsky", "Belitrov", "Belochkin", "Beloglazov", "Belomestin", "Belomestnov", "Belomestny", "Belomestnykh", "Belomestov", "Belorusov", "Belousov", "Belousov", "Belov", "Belyakov", "Bendlin", "Benediktov", "Berezhnoy", "Berezin", "Beriya", "Bershov", "Besfamilny", "Beskryostnov", "Bespalov", "Bessonov", "Bezborodov", "Bezrodny", "Bezrukov", "Bezukladnikov", "Biryukov", "Blanter", "Blatov", "Blazhenov", "Blinov", "Blok", "Blokhin", "Blokov", "Blum", "Bobkov", "Bobr", "Bobrik", "Bobrov", "Bocharov", "Bodrov", "Bogachyov", "Bogatyryov", "Bogdanov", "Bogolepov", "Bogolyubov", "Bogomazov", "Bogomolov", "Bogrov", "Bogun", "Bok", "Bokaryov", "Boldayev", "Boldyrev", "Bolotnikov", "Bolshakov", "Bolshov", "Boltonogov", "Bondarchuk", "Bondarev", "Boreyev", "Borisyuk", "Borodin", "Bortnik", "Bortsov", "Borzilov", "Bovarin", "Boyarov", "Boydalo", "Boykov", "Boytsov", "Bragin", "Brantov", "Brezhnev", "Brusilov", "Budanov", "Budayev", "Budnikov", "Budylin", "Bugakov", "Bugaychuk", "Bugayev", "Bukavitsky", "Bukhalo", "Bukin", "Bukir", "Buklin", "Bukov", "Bulgakov", "Bulygin", "Bunin", "Burdukovsky", "Burkov", "Burmakin", "Burov", "Burtsov", "Bury", "Buryakov", "Buturovich", "Butusov", "Butylin", "Buzinsky", "Bychkov", "Bykov", "Bylinkin", "Bодовос", "Camapnh", "Chaadayev", "Chadov", "Chaly", "Chapayev", "Charkov", "Chayka", "Chaykovsky", "Chazov", "Chebotaryov", "Chebykin", "Chekhov", "Chekmaryov", "Chekudayev", "Chelomey", "Chelomeyev", "Chelomtsev", "Chelpanov", "Chemeris", "Chendev", "Chepurin", "Cherenchikov", "Cherepanov", "Cherkashin", "Cherkasov", "Chernakov", "Chernetsky", "Chernikov", "Chernobrovin", "Chernomyrdin", "Chernov", "Chernyavsky", "Chernykh", "Chernyshyov", "Chesnokov", "Chezhekov", "Chichikov", "Chichkanov", "Chigrakov", "Chilayev", "Chirkash", "Chistyakov", "Chizhikov", "Chkalov", "Chmykhov", "Chubarov", "Chuchanov", "Chuchumashev", "Chudov", "Chugunov", "Chukchov", "Chukreyev", "Chumakov", "Chupakhin", "Chupalov", "Chupov", "Chuprakov", "Chuprin", "Chuprov", "Churkin", "Chuzhinov", "Daniltsin", "Danshov", "Datsishin", "Davydkin", "Davydov", "Dedov", "Degtyarev", "Delov", "Demenok", "Dementyev", "Dementyev", "Demidov", "Denikin", "Denisov", "Dernov", "Derzhavin", "Desyatkov", "Dezhnyov", "Dmitriyev", "Dobrolyubov", "Dobronravov", "Dobrynin", "Dolgorukov", "Dolzhikov", "Domashev", "Domnin", "Dorofeyev", "Dorokhin", "Dorokhov", "Dostovalov", "Dragomirov", "Dragunov", "Dresvyanin", "Drotenkov", "Drotenkov", "Druganin", "Drugov", "Dryagin", "Dryomov", "Dubinin", "Dubinkin", "Dubolazov", "Dubov", "Dubrovsky", "Dudin", "Dudko", "Dudnik", "Dultsev", "Dumanovsky", "Dunayevsky", "Duranichev", "Durchenko", "Durov", "Dvornikov", "Dvoynev", "Dyatlov", "Dykhovichny", "Dyogtin", "Dyomin", "Dyrbov", "Dyuzhenkov", "Ekel", "Elefterov", "Elkin", "Elmpt", "Emanuil", "Emin", "Emskikh", "Emsky", "Engalychev", "Engelgardt", "Engovatov", "Entin", "Entsky", "Epinger", "Erdeli", "Eristov", "Ernet", "Eshman", "Esmond", "Essen", "Estse", "Etush", "Eybozhenko", "Fammus", "Famusov", "Fanin", "Fedchenkov", "Fedin", "Fedoseyev", "Fedosov", "Fedotov", "Fedulov", "Fekhlachev", "Fenenko", "Fetisov", "Filatov", "Filchenkov", "Filenkov", "Filimonov", "Filipov", "Filippov", "Firsov", "Flyorov", "Fokin", "Fomenkov", "Fomichyov", "Fomin", "Fonvizin", "Foroponov", "Franko", "Frantsev", "Frolov", "Fukin", "Furmanov", "Fyodorov", "Fyokhlachev", "Gachev", "Gagarin", "Gagolin", "Galdin", "Galerkin", "Galiaskarov", "Galkin", "Galygin", "Garanin", "Garifullin", "Garin", "Gavrikov", "Gavrilenkov", "Gavrilov", "Genkin", "Gerasimov", "Gibazov", "Gilyov", "Glagolev", "Glazkov", "Glebov", "Glinin", "Globa", "Glukhov", "Golodyayev", "Golov", "Golovakha", "Golovanov", "Golovin", "Golovkin", "Golubev", "Golubkin", "Golubov", "Golubtsov", "Golumbovsky", "Goncharov", "Goraya", "Gorbachyov", "Gorbunkov", "Gorbunov", "Gorelov", "Goremykin", "Gorev", "Gorokhin", "Gorokhov", "Gorostayev", "Gorshkov", "Goryunov", "Grachyov", "Grafov", "Grankin", "Grebenshchikov", "Grekov", "Greshnev", "Gribanov", "Gribkov", "Gribov", "Griboyedov", "Grigoryev", "Grinin", "Grishin", "Gromov", "Grushanin", "Gruzdev", "Gruzinsky", "Gryaznov", "Gubanov", "Gulin", "Gunin", "Gurkovsky", "Guryanov", "Guryev", "Gusarov", "Gusev", "Gushchin", "Gusin", "Guskov", "Guslyakov", "Ignatkovich", "Ignatyev", "Igoshin", "Igumnov", "Ikanov", "Ikashev", "Ilkun", "Ilyasov", "Ilyin", "Ilyukhin", "Ilyushin", "Ilyushin", "Ilyushkin", "Inozemtsev", "Inshov", "Ipatyev", "Isayev", "Ishutin", "Ismaylov", "Istomin", "Ivakin", "Ivankov", "Ivanov", "Ivashin", "Ivashov", "Ivazov", "Ivchenko", "Ivkin", "Ivolgin", "Izhutin", "Izmaylov", "Izyumov", "Kabinov", "Kablukov", "Kachusov", "Kadnikov", "Kadtsyn", "Kadurin", "Kalagin", "Kalashnik", "Kalganov", "Kalinin", "Kalugin", "Kalyagin", "Kamenskikh", "Kamkin", "Kanadin", "Kanadov", "Kanadtsev", "Kanalin", "Kandinsky", "Kapitsa", "Kapralov", "Kapriyanov", "Kapustin", "Kapustov", "Kapylyushny", "Karandashov", "Karantirov", "Karaulin", "Karaulov", "Karavayev", "Karbainov", "Karchagin", "Karetnikov", "Karev", "Kargin", "Kariyev", "Karnaukhov", "Kartashov", "Kartashyov", "Karyavin", "Karzhov", "Kasaty", "Kasharin", "Kashirin", "Kashirsky", "Kashkanov", "Kashnikov", "Kashuba", "Kasyanenko", "Kasyanov", "Katayev", "Katerinochkin", "Katin", "Kaverin", "Kazakov", "Kazankov", "Kazantsev", "Kazarezov", "Kedrov", "Khabalov", "Khabarov", "Khabensky", "Khalipov", "Khalski", "Khalturin", "Khamidullin", "Khanilov", "Khanipov", "Khantsev", "Kharitonov", "Kharlamov", "Kharmats", "Kharzin", "Khaslik", "Khigir", "Khlebnikov", "Khlebov", "Khloponin", "Khmelnov", "Khodyayev", "Khokhlachev", "Kholod", "Kholodov", "Khomkolov", "Khorkov", "Khramov", "Khrebtov", "Khromov", "Khrushchyov", "Khudovekov", "Khudyakov", "Khurtin", "Khvostovsky", "Kilesso", "Kipriyanov", "Kirdan", "Kireyev", "Kirigin", "Kirilishen", "Kirillov", "Kirillovsky", "Kirilov", "Kirsanov", "Kiryanov", "Kislukhin", "Klepak", "Klepakhov", "Klepin", "Klimov", "Klimtsov", "Klimushin", "Klokov", "Knyazev", "Kochenkov", "Kocheryozhkin", "Kolesnikov", "Kolesov", "Kollerov", "Kolobkov", "Kolomnikov", "Kolontayev", "Kolosov", "Koltsov", "Kolupayev", "Komarov", "Komissarov", "Komolov", "Komzin", "Kondratyev", "Kondurov", "Kondyurin", "Konev", "Konnikov", "Konovalov", "Konyakov", "Konyashev", "Kopeykin", "Kopsov", "Koptsev", "Korablin", "Korablyov", "Korchagin", "Korenev", "Korenyov", "Kornev", "Korneyev", "Kornilov", "Korolyov", "Korotayev", "Korotkin", "Korotkov", "Korovin", "Kortnev", "Koryavin", "Koryavov", "Korzhakov", "Korzhev", "Kosaryov", "Koshechkin", "Koshelev", "Koshkin", "Koshkov", "Koskov", "Kosma", "Kosomov", "Kosorukov", "Kostin", "Kostomarov", "Kosyak", "Kotov", "Kovalenko", "Kovalevsky", "Kovalyov", "Kovrov", "Kovshevnikov", "Kovshutin", "Koychev", "Kozakov", "Kozar", "Kozhukhov", "Kozhurov", "Kozlov", "Kozlovsky", "Kozyrev", "Krasnoperov", "Krasnov", "Krasotkin", "Kravchuk", "Krayev", "Krayevsky", "Krivkov", "Krivoukhov", "Krivov", "Kriоutchkov", "Kropanin", "Kruchinkin", "Kruglikov", "Kruglov", "Krupin", "Krupnov", "Krutikov", "Krutin", "Krutov", "Krutoy", "Krylov", "Krymov", "Krysov", "Kryukov", "Kublanov", "Kubyshkin", "Kudashov", "Kudrin", "Kudryashov", "Kudryavtsev", "Kuimov", "Kuklachyov", "Kuklev", "Kuklin", "Kuklov", "Kulagin", "Kulakov", "Kulibin", "Kulik", "Kulikov", "Kuptsov", "Kurakin", "Kurbatov", "Kurchin", "Kurdin", "Kurepin", "Kurganov", "Kuritsyn", "Kurochkin", "Kurpatov", "Kursalin", "Kurtashkin", "Kustov", "Kutepov", "Kutikov", "Kutuzov", "Kutyakov", "Kuvayev", "Kuzkin", "Kuzmich", "Kuzmin", "Kuznetsov", "Kuzubov", "Lachinov", "Lachkov", "Lagoshin", "Lagransky", "Lagutov", "Lantsov", "Lapayev", "Lapidus", "Lapin", "Lapotnikov", "Laptev", "Lapukhov", "Lapunov", "Larin", "Larionov", "Laskutin", "Lavrentyev", "Lavrov", "Lazarev", "Lebedev", "Lebedinsky", "Lebedintsev", "Ledovskoy", "Legkodimov", "Lel", "Lelukh", "Leonidov", "Leonov", "Lepyokhin", "Lermontov", "Leshchyov", "Leshev", "Leskov", "Lesnichy", "Letov", "Levin", "Levkin", "Lidin", "Likhachyov", "Lilov", "Limonov", "Lipin", "Lipov", "Lisitsyn", "Lisov", "Listratov", "Listunov", "Lobachyov", "Loban", "Lobanov", "Lobov", "Loginov", "Loginovsky", "Loktev", "Loktionov", "Lomonosov", "Lomovtsev", "Lomtev", "Lopatin", "Losev", "Losevsky", "Loshchilov", "Loskutnikov", "Loskutov", "Lovzansky", "Lubashev", "Lukashenko", "Lukin", "Lukov", "Lukyanenko", "Lukyanov", "Luski", "Luzhkov", "Lvov", "Lyadov", "Lyagushkin", "Lyagushov", "Lyalyushkin", "Lyamin", "Lyapin", "Lyapunov", "Lyasin", "Lyovkin", "Lytkin", "Lyubimov", "Lyubimtsev", "Lyubov", "Lyutenkov", "Lyutov", "Lyzlov", "Madulin", "Mager", "Magomedov", "Makarov", "Makhmudov", "Maklakov", "Maksimov", "Maksimushkin", "Maksudov", "Malakhov", "Malchikov", "Malikov", "Malinin", "Malinov", "Malykhin", "Malyshev", "Malyugin", "Mamin", "Mamonov", "Mamykin", "Manin", "Mantorov", "Manyakin", "Marin", "Marinin", "Marinkin", "Marinov", "Markin", "Markov", "Martyushev", "Maryin", "Masharin", "Mashir", "Maslak", "Maslov", "Masmekh", "Masmekhov", "Matveyev", "Maysak", "Mazhulin", "Mednikov", "Medvedev", "Medvedkov", "Mekhantyev", "Meledin", "Melekhov", "Melikov", "Melnikov", "Menshchikov", "Menshikov", "Merkulov", "Merkushev", "Meshcheryakov", "Mesyats", "Migunov", "Mihaylovna", "Mikhalev", "Mikhalitsin", "Mikhalitsyn", "Mikhaylov", "Mikheyev", "Milekhin", "Miloradov", "Milyukov", "Milyutin", "Minayev", "Mineyev", "Minin", "Minkin", "Minkovski", "Mirnov", "Mirokhin", "Mironov", "Mirov", "Misalov", "Mishin", "Mishnev", "Mishutin", "Mitin", "Mitrofanov", "Mizenov", "Moiseyev", "Mokhov", "Molchanov", "Mordvinov", "Morenov", "Moroshkin", "Morozov", "Moryakov", "Mosalev", "Mosin", "Moskvin", "Mosyakov", "Mozhayev", "Mukhanov", "Mukhin", "Mukhomorov", "Mukhortov", "Mukhov", "Muratov", "Muravyov", "Murogov", "Myagkov", "Myasnikov", "Myatlev", "Myaukin", "Myshelov", "Myshkin", "Nabatov", "Nardin", "Nasonov", "Naumenko", "Naumov", "Nazarov", "Nechayev", "Nedelyayev", "Nekrasov", "Nekrestyanov", "Nemtsev", "Nemtsov", "Nenashev", "Nepein", "Nesterov", "Netrebov", "Nevzorov", "Nezhdanov", "Nikiforov", "Nikishin", "Nikitin", "Nikolayev", "Nikonov", "Nikulin", "Nizamutdinov", "Norin", "Nosachyov", "Noskov", "Nosov", "Novichkov", "Novikov", "Novokshonov", "Novoseltsev", "Nozdrin", "Nozdryov", "Nuriyev", "Obnizov", "Obolensky", "Oborin", "Obraztsov", "Obukhov", "Ogorodnikov", "Ogurtsov", "Olenev", "Olkhovsky", "Omelnitskiy", "Onegin", "Onipchenko", "Opokin", "Oprinchuk", "Orlov", "Osennykh", "Oshurkov", "Osin", "Osinov", "Osintsev", "Osminin", "Osokin", "Osolodkin", "Ostaltsev", "Ostapyuk", "Ostroverkhov", "Ostrovsky", "Ovechkin", "Ovechkin", "Ozerov", "Pakhomov", "Palyulin", "Panarin", "Panfilov", "Panin", "Pankin", "Pankiv", "Pankov", "Pankratov", "Papanov", "Paramonov", "Parshikov", "Parshin", "Pashin", "Pashkov", "Paskhin", "Pasternak", "Pastukh", "Patrushev", "Paulkin", "Pavlenko", "Pavlov", "Pechenikov", "Pechkin", "Pelevin", "Pelyovin", "Penkin", "Perekhvatkin", "Perestoronin", "Perevalov", "Pereverzev", "Perevyortov", "Perezhogin", "Perfilyev", "Perminov", "Permyakov", "Perov", "Pervak", "Pestov", "Petrov", "Petrukhin", "Petukhov", "Pevtsov", "Pichugin", "Pichushkin", "Pimenov", "Pirogov", "Pirozhkov", "Pishchalnikov", "Pitosin", "Pivovarov", "Plaksin", "Platonov", "Plemyannikov", "Poda", "Podshivalov", "Pogodin", "Pogodov", "Pogrebnov", "Pokrovsky", "Polachev", "Polichev", "Polishchuk", "Polivanov", "Polotentsev", "Polovtsev", "Poltanov", "Poltorak", "Polunin", "Polushin", "Polyakov", "Pomelnikov", "Pomelov", "Ponchikov", "Pondyakov", "Ponikarov", "Ponomaryov", "Popov", "Popyrin", "Portnov", "Posokhov", "Post", "Potapov", "Potrepalov", "Potyomkin", "Pozdnyakov", "Pozharsky", "Prazdnikov", "Preobrazhensky", "Pribylov", "Prikhodko", "Primakov", "Privalov", "Prokhorov", "Pronichev", "Pronin", "Proskurkin", "Protasov", "Pshenichnikov", "Pudin", "Pudovkin", "Pugachyov", "Pugin", "Pushkaryov", "Pushkin", "Pushnoy", "Putilin", "Putilov", "Putin", "Putinov", "Putyatin", "Puzakov", "Puzanov", "Pyanykh", "Pyatosin", "Pyryev", "Pyzhalov", "Rabinovich", "Rabrenovich", "Rafikov", "Ramazanov", "Raskalov", "Raspopov", "Rasputin", "Rasskazov", "Rastorguyev", "Rayt", "Razin", "Razuvayev", "Remizov", "Repin", "Reshetilov", "Reshetnikov", "Retyunskikh", "Revyagin", "Revyakin", "Rezansov", "Reznikov", "Rodchenko", "Rodin", "Rodzyanko", "Rogachyov", "Rogov", "Rogozin", "Rokossovsky", "Romanov", "Roshchin", "Rostov", "Rostovtsev", "Rozanov", "Rozhkov", "Rozovsky", "Rubashkin", "Ruchkin", "Rudavin", "Rudin", "Rudnikov", "Rudov", "Rugov", "Rumyantsev", "Runov", "Rusakov", "Rusanov", "Ruskikh", "Rusnak", "Russkikh", "Ryabkin", "Ryabkov", "Ryabov", "Ryabtsev", "Ryakhin", "Rybakov", "Rybalkin", "Rychenkov", "Rykov", "Rytin", "Ryurikov", "Ryzhanov", "Ryzhikov", "Ryzhkov", "Ryzhov", "Rzhevsky", "Sabantsev", "Sabitov", "Sadovsky", "Sadykov", "Safiyulin", "Safronov", "Sagadeyev", "Saitov", "Sakharov", "Salagin", "Salko", "Salkov", "Salnikov", "Saltanov", "Samarin", "Samokhin", "Samoylov", "Samsonov", "Sannikov", "Sapalyov", "Sapogov", "Sapozhnikov", "Saprykin", "Sarnychev", "Savasin", "Savenkov", "Savinkov", "Savrasov", "Savvatimov", "Savvin", "Say", "Sayan", "Sayankin", "Sayankov", "Sayanov", "Sayanovich", "Sayansky", "Saytakhmetov", "Sazonov", "Schastlivtsev", "Sechenov", "Sedelnikov", "Sedov", "Seleznyov", "Selidov", "Selivanov", "Semerikov", "Semichayevsky", "Semyanin", "Semyonov", "Senkin", "Senotrusov", "Serebrov", "Serebryakov", "Sergeyev", "Serov", "Serpionov", "Seryogin", "Severinov", "Severov", "Sevostyanov", "Shabalin", "Shabunin", "Shagidzyanov", "Shakmakov", "Shalomentsev", "Shalyapin", "Shapiro", "Shaposhnikov", "Shapovalov", "Sharapov", "Sharonov", "Sharov", "Sharshin", "Shashlov", "Shastin", "Shatalov", "Shchavelsky", "Shchavlev", "Shchedrin", "Shchedrov", "Shchegelsky", "Shcheglov", "Shchegolev", "Shchegolikhin", "Shchegolyayev", "Shchekochikhin", "Shchepkin", "Shcherbakov", "Shcherbatykh", "Shcherbina", "Shchetinin", "Shchetkin", "Shchitt", "Shchukin", "Shchurov", "Shelagin", "Shelepov", "Shelomov", "Shelyapin", "Shepkin", "Shepovalov", "Sheremetyev", "Sherkov", "Sherstov", "Shevelyok", "Shibalov", "Shigayev", "Shigin", "Shikalov", "Shikhov", "Shikhranov", "Shinsky", "Shirinov", "Shirmanov", "Shirokov", "Shishkanov", "Shishkin", "Shishko", "Shishlov", "Shishov", "Shkuratov", "Shkut", "Shlykov", "Shmagin", "Shmakov", "Shmelev", "Shpak", "Shpikalov", "Shubin", "Shubkin", "Shukshin", "Shuldeshov", "Shulga", "Shulgin", "Shulichenko", "Shults", "Shulyov", "Shursha", "Shurshalin", "Shurupin", "Shurupov", "Shurygin", "Shushalev", "Shustelyov", "Shuvalov", "Shuysky", "Shvedov", "Shvernik", "Sidorov", "Sigachyov", "Sigalov", "Sigayev", "Silayev", "Silin", "Silivanov", "Silvestrov", "Simakin", "Simonov", "Sitnikov", "Sivakov", "Siyakayev", "Siyalov", "Siyan", "Siyanchuk", "Siyangulov", "Siyanin", "Siyanitsa", "Siyankin", "Siyanko", "Siyankov", "Siyankovsky", "Siyanosov", "Siyanov", "Siyanovich", "Siyanskikh", "Siyansky", "Siyantsev", "Siyasinov", "Sizov", "Sizy", "Skorobogatov", "Skorokhodov", "Skryabin", "Skuratov", "Skvortsov", "Slavsky", "Slepynin", "Slobozhanin", "Sluchevsky", "Smagin", "Smekhov", "Smeshnoy", "Smetanin", "Smirnitsky", "Smirnov", "Smolin", "Smolyaninov", "Smotrov", "Snatkin", "Snegiryov", "Snetkov", "Sobachkin", "Sobakov", "Sobchak", "Sobolev", "Sobolevsky", "Sochinsky", "Sokolov", "Soldatov", "Solodnikov", "Solodskikh", "Solomakhin", "Solomin", "Solomonov", "Solovyov", "Somov", "Sonin", "Sopov", "Sorokin", "Soverighn", "Spanov", "Spravtsev", "Stalin", "Starikov", "Starodubov", "Starodubtsev", "Staroverov", "Starovolkov", "Startsev", "Statnik", "Steblev", "Stegnov", "Stepankov", "Stepanov", "Stepashin", "Stepnov", "Stezhensky", "Strekalov", "Strelkov", "Strelnikov", "Streltsov", "Stroganov", "Subbotin", "Subotin", "Suchkov", "Sudlenkov", "Sukachyov", "Sukhanov", "Sukharnikov", "Sukhikh", "Sukhorukov", "Sukin", "Sultanov", "Sungatulin", "Suprunov", "Surikov", "Surkov", "Surnin", "Suslyakov", "Susnin", "Susoyev", "Sutulin", "Suvorin", "Suvorkin", "Suvorov", "Svalov", "Syanov", "Sychkin", "Sychyov", "Syomin", "Sysoyev", "Sytnikov", "Syukosev", "Tabakov", "Tabernakulov", "Talalikhin", "Talanov", "Tamakhin", "Tamarkin", "Tankov", "Tarasov", "Tarnovetsky", "Tatarinov", "Tatarintsev", "Tatarov", "Tataurov", "Tattar", "Taushev", "Telitsyn", "Teplov", "Terebov", "Terekhov", "Tereshchenko", "Teryoshin", "Teterev", "Tikhokhod", "Tikhomirov", "Tikhonenko", "Tikhonov", "Tikhvinsky", "Timofeyev", "Timoshenko", "Timoshkin", "Tipalov", "Titov", "Tkachenko", "Tkachyov", "Tokarev", "Tokmakov", "Tolbanov", "Tolkachyov", "Tolmachyov", "Tolokonsky", "Tolstobrov", "Tolstokozhev", "Tolstoy", "Toporkov", "Toporov", "Torchinovich", "Toropov", "Traktirnikov", "Trapeznikov", "Travkin", "Travnikov", "Tredyakovsky", "Tretyakov", "Trifonov", "Trofimov", "Trufanov", "Trukhin", "Trusov", "Trutnev", "Tryndin", "Tsaplin", "Tsaregorodtsev", "Tsaritsyn", "Tsarsko", "Tsaryov", "Tsedlits", "Tsekhanovetsky", "Tselikovsky", "Tselner", "Tsereteli", "Tseydlerin", "Tseydlits", "Tsigler", "Tsimmerman", "Tsiolkovsky", "Tsiryulnikov", "Tsitnikov", "Tsitsyanov", "Tsukanov", "Tsulukidze", "Tsvetayev", "Tsvetkov", "Tsvetnov", "Tsvilenev", "Tsyganov", "Tsyrinsky", "Tsyrkunov", "Tsyzyrev", "Tumasov", "Tupitsyn", "Tupolev", "Turbin", "Turfanov", "Turgenev", "Turov", "Tvardovsky", "Tyannikov", "Tychkin", "Tyomkin", "Tyushnyakov", "Uashington", "Ubeysobakin", "Ubysh", "Udom", "Uglichinin", "Uglitsky", "Uglov", "Ugolev", "Ugolnikov", "Uitsky", "Ukhov", "Ukhtomsky", "Uladimov", "Ulanov", "Ulitsky", "Ulyanin", "Ulyanov", "Ulyashin", "Umametev", "Umanov", "Umsky", "Ungern", "Unkovsky", "Untilov", "Urakov", "Uralets", "Urbanovsky", "Urusov", "Usachyov", "Usatov", "Usenko", "Ushakov", "Usilov", "Usov", "Usoyev", "Uspensky", "Ustimovich", "Ustinov", "Ustyuzhanin", "Utterklo", "Utyosov", "Utyuzhin", "Uvarov", "Vagin", "Vakhrov", "Vakhrushev", "Valevach", "Vanzin", "Varennikov", "Varushkin", "Vasilyev", "Vasilyevykh", "Vasin", "Vasnetsov", "Vasnev", "Vavilov", "Vazov", "Vedeneyev", "Vedenin", "Vedernikov", "Venediktov", "Vereshchagin", "Vergunov", "Vershinin", "Veselov", "Veselovsky", "Vetochkin", "Vetrov", "Vikashev", "Vikhrov", "Vinogradov", "Vinokurov", "Vitayev", "Vitsin", "Vitvinin", "Vlacic", "Vodoleyev", "Vodovatov", "Vodovos", "Vodyanov", "Volikov", "Volkov", "Volodin", "Voloshin", "Volvakov", "Vorobyov", "Voronin", "Voronkov", "Voronov", "Vorontsov", "Voskoboynikov", "Votyakov", "Vyalitsyn", "Vyrypayev", "Yablokov", "Yablonev", "Yablonsky", "Yagovkin", "Yakimenko", "Yakimov", "Yakovlev", "Yakubov", "Yakubovich", "Yakunin", "Yakushev", "Yakushin", "Yamskikh", "Yanayev", "Yankov", "Yankovsky", "Yanukovich", "Yarmolnik", "Yaromeyev", "Yaroslavsky", "Yaroslavtsev", "Yartsev", "Yartsin", "Yasenev", "Yashin", "Yashkin", "Yasneyev", "Yaytsev", "Yazov", "Yedemsky", "Yefimov", "Yefremov", "Yegorov", "Yelagin", "Yelchukov", "Yeleshev", "Yeliseyev", "Yelizarov", "Yeltsin", "Yeltsov", "Yemelin", "Yemelyanov", "Yenin", "Yenotin", "Yenotov", "Yerkhov", "Yerkulayev", "Yermakov", "Yermilov", "Yermolayev", "Yermolov", "Yermushin", "Yerofeyev", "Yerokhin", "Yeromeyev", "Yershov", "Yeryomin", "Yerzov", "Yesaulov", "Yeshevsky", "Yesikov", "Yesipov", "Yevdokimov", "Yevseyev", "Yevstigneyev", "Yevtushenkov", "Yezhov", "Yolkin", "Yolkov", "Yozhikov", "Yozhin", "Yozhov", "Yubkin", "Yudachyov", "Yudashkin", "Yudin", "Yuditsky", "Yuferev", "Yugantsev", "Yugov", "Yukhantsev", "Yukhtrits", "Yumashev", "Yumatov", "Yunevich", "Yunge", "Yunkin", "Yurakin", "Yurasov", "Yurenev", "Yurkov", "Yurlov", "Yurnayev", "Yuryev", "Yushakov", "Yushkov", "Yusupov", "Yutilov", "Yuvelev", "Zabolotny", "Zadornov", "Zadorozhny", "Zakharchenko", "Zakharin", "Zakharov", "Zakrevsky", "Zakryatin", "Zaporozhets", "Zarubin", "Zaslavsky", "Zavragin", "Zavrazhin", "Zavrazhnov", "Zavrazhny", "Zavrazin", "Zavyalov", "Zaytsev", "Zefirov", "Zhabin", "Zharkov", "Zharykhin", "Zhdanov", "Zheglov", "Zhelezkin", "Zheleznov", "Zherdev", "Zhernakov", "Zhestakova", "Zhidkov", "Zhiglov", "Zhigunov", "Zhikin", "Zhilin", "Zhilov", "Zhirenkov", "Zhirov", "Zhivenkov", "Zholdin", "Zhukov", "Zhuravlyov", "Zhurov", "Zhutov", "Zhvikov", "Zhzhyonov", "Zimin", "Zimnyakov", "Zinchenko", "Zlobin", "Zolin", "Zolotov", "Zonov", "Zorin", "Zotov", "Zubarev", "Zubkov", "Zubov", "Zuyev", "Zuykov", "Zverev", "Zvyagin", "Zykin", "Zykov", "Zyomin", "Zyryanov", "Zyuganov" };
           
        }
        public object generate(Type t)
        {
            Random rand = new Random(DateTime.Now.Second);


            if (t == typeof(string))
            {
                return (object)surnames.OrderBy(xx => rand.Next()).First();

            }
            else { return null; }
        }
    }
}

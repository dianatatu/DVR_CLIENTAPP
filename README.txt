============== OPTIMIZAREA TRAFICULUI PE RETEA ====================

1.	Prezentare generala a sistemului.
In schema de jos este prezentata structura generala de legare a echipamentelor DVR si a aplicatiei client in retea. Dupa cum se poate observa posibilul bottleneck apare la legarea a mai multor DVR-uri la aceeasi aplicatie client, dar un modul de optimizare este util si atunci cand vorbim de conexiune 1 la 1, reducand consturile necesare infrastructurii de retea.

DVR			DVR			DVR		... 	DVR	 	DVR		DVR
|			|			|				|		|		|
|			|			|				|		|		|
|			|			|				|		|		|
---------------------------------------------------------
							|
							|
							|
							|
						LAN / WAN
					Possible bottleneck
							|
							|
							|
							|
						Client SW

Aplicatia client schimba mai multe tipuri de informatii cu aplicatiile DVR din teren:
-	Stari (online, defect, camera fara semnal etc)
-	Imagini in direct
-	Imagini inregistrate
-	Setari ale DVR-urilor care pot fi modificate de la distanta
-	Alte informatii
Acest modul de reducere a traficului va fi implementat pe imaginile vizualizate in direct (cele inregistrate trebuiesc trimise la rezolutia / calitatea originala).

Cateva din criteriile care pot fi aplicate pentru a obtine reducerea traficului pe retea sunt:
a.	Redimensionarea imaginilor care vor fi transmise.
b.	Transformarea imaginilor transmise in alb-negru.
c.	Reducerea calitatii compresiei imaginilor
d.	Micsorarea numarului de cadre pe secunda transmise
In cadrul acestui modul prioritatile principale sunt punctele a si b. De asemenea se poate gandi si un mod in care sa se obtina o setare dinamica (in functie de viteza maxima disponibila) pentru gradul de optimizare.


2.	Structura aplicatiilor.
Aplicatiile vor fi dezvoltate sub forma de dll-uri (1 dll care va sta langa Aplicatia Client si 1 dll care va sta langa Aplciatia DVR). Se vor folosi, cel putin intr-o prima faza, simulatoare care vor tine locul Aplicatiilor DVR si Client. 
Dll-urile vor fi dezvoltate astfel incat sa se asigure compatibilitatea lor cu limbajul C++ (Aplicatiile Client si DVR sunt dezvoltate in Visual Studio 2008). Daca ele vor fi dezvoltate in alt limbaj in afara de C++, se va asigura compatibilitatea prin COM (sau orice alta tehnologie doriti, atata timp cat rezolva aceasta problema).
Este de asemenea posibil ca algoritmii de prelucrare a imaginilor sa aiba nevoie sa fie scrisi in limbaj ASM, in functie de gradul de ocupare al procesorului.


ClientOptDll: reprezinta functiile care vor fi accesibile din dll-ul atasat aplicatiei client. Avem variabilele:
-	Shape (shape-ul de vizualizare, este un int care va reprezenta un anumit cod pentru fiecare modalitate de vizualizare)
-	resCamX reprezinta o lista de numere intregi care reprezinta rezolutia orizontala in care va vor fi cerute imaginile pentru fiecare din cele 16  sau 32 de camere
-	resCamY reprezinta o lista de numere intregi care reprezinta rezolutia verticala in care va vor fi cerute imaginile pentru fiecare din cele 16  sau 32 de camere
-	resMonitorX reprezinta rezolutia monitorului pe orizontala
-	resMonitorY reprezinta rezolutia monitorului pe verticala
-	Ips este o lista de siruri care retine IP-urile fiecarui DVR
-	Ports este o lista de int care retine portul pe care este facuta comunicatia cu fiecare DVR in parte
Functiile disponibile sunt:
-	SetShape (int shape) declara in ce shape de vizualizare merge aplicatia.
-	CalculateRes () calculeaza si salveaza intr-o structura interna rezolutia in care merge fiecare camera.
-	SetResCamX(int cam, int resX) – seteaza rezolutia (componenta orizontala) in care va functiona o anumita camera.
-	SetResCamY(int cam, int resY) – seteaza rezolutia (componenta verticala) in care va functiona o anumita camera.
-	SetResMonitorX(int resX) - seteaza rezolutia (componenta orizontala) in care functioneaza monitorul.
-	SetResMonitorY(int resY) - seteaza rezolutia (componenta verticala) in care functioneaza monitorul.
-	GetShape () : int shape – returneaza shapeul de vizualizare in care merge aplicatia.
-	GetResX(int cam) : int resX – returneaza rezolutia (componenta X) pentru o anumita camera.
-	GetResY(int cam) : int resY – returneaza rezolutia (componenta Y) pentru o anumita camera.

DVROptDll – reprezinta functiile care vor fi accesibile din dll-ul atasat aplicatiei DVR. Avem variabilele:
-	Port – portul pe care aplicatia asteapta conexiuni
-	resCamX – lista de int care retine rezolutia (componenta X) in care vor fi trimise imaginile pe fiecare camera in parte
-	resCamY – lista de int care retine rezolutia (componenta Y) in care vor fi trimise imaginile pe fiecare camera in parte
-	bwCam – lista de bool care retine ce camere vor fi setate sa comunice alb-negru
-	images – lista de imagini
Si functiile:
-	Listen (int port) – functie de ascultare, asteapta conexiuni de la client pe un anumit port.
-	RecvResCamX (int cam, int resX) – primeste de la client si seteaza rezolutia (componenta X) pentru o anumita camera.
-	RecvResCamY (int cam, int resY) – primeste de la client si seteaza rezolutia (componenta X) pentru o anumita camera.
-	RecvBWCam(int cam, bool bw) – primeste de la client informatia si seteaza daca o anumita camera va transmite imagini alb negru.
-	AddImage (IMAGE) – adauga o imagine noua in lista celor care vor fi prelucrate
-	GetFirstImage () : IMAGE – returneaza prima imagine din lista, si face indexul functiilor Get... = 0
-	GetNextImage () : IMAGE – returneaza urmatoare imagine din lista si incrementeaza indexul la care se afla functiile Get...
-	GetLastImage () : IMAGE – returneaza ultima imagine din lista si face indexul = nr total de imagini – 1.
-	GetImageCount () : int – returneaza numarul de imagini din lista.
-	DeleteImage(int index) – sterge imaginea de la indexul primit
-	DeleteAllImages – sterge toate imaginile din lista.
-	Process (IMAGE) – proceseaza o anumita imagine conform criteriilor selectate. In variabila primita va fi suprascris rezultatul dupa procesare.

3.	Structura IMAGE.
Dll-ul de DVR va primi doar imagini necomprimate (RGB, YUV), si va returna tot imagini necomprimate. Compresia imaginilor in format MJPEG, DIVX sau H.264 si trimiterea lor prin retea va fi facuta de module deja existente ale aplicatiei.
Ca propunere structura IMAGE poate fi de forma:
-	int Width
-	int Height
-	int BitCount
-	int Format
-	int ByteArrayLen
-	BYTEARRAY ImageData
Variabila format va defini daca imaginea este de tip RGB sau YUV .Aici trebuie analizat modul in care vor fi interpretate aceste imagini astfel:
-	Daca se scriu algoritmi separati pentru procesarile pe YUV si pe RGB
-	Daca se scrie un algoritm de transformare din YUV-RGB (sau invers) si se face procesarea doar pe unul din aceste doua spatii de culori.


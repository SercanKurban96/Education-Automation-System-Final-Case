# Education Automation System Final Case
Eğitim alanında kullanmak için C# ile ADO.NET ve Entity Framework ile geliştirilmiş bir otomasyon.
Bu otomasyonumuzda ilk olarak ekrana bir dil seçeneği çıkmaktadır. Türkçe veya İngilizce dillerinden birini seçtikten sonra otomasyonumuza giriş yapıyoruz.




![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/bfd3bf1b-387c-4918-9ec9-fea57039a2f0)

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/aa5bf757-7f7c-43a1-a222-36dc3c5a308a)

Bu sistemimizde Yönetici, Akademisyen ve Öğrenci olmak üzere 3 tane giriş paneli bulunmaktadır. İlk olarak Yönetici paneliyle giriş yapalım.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/45ce81d9-1331-4531-9aae-04827337175d)

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/59885023-8c88-44e1-bdf8-027e08afbb5c)

Yönetici girişi için karşımıza bu şekilde çıkacaktır. Giriş yaptıktan sonra Yönetici Panel açılacaktır.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/839b7568-226f-4308-a8ca-64297a524bd5)

Bu panelde Bölüm, Öğrenci, Akademisyen ve Duyuru için ekleme, silme, güncelleme işlemleri yapılmaktadır. Örnek olarak bölüm kısmına gidip ekleme işlemini yapalım.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/8d530083-b92a-4efe-9671-fdd1e80d5498)

Bu panelde her bir işlem için ayrı form oluşturulmuştur. Ekleme işlemini yapalım.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/c51a1f8a-cb19-45b4-ba8f-90a2af4fc5aa)

Bölüm ekleme için isim kısmının boş olmaması veya 5 karakterden az olmaması gerekmektedir. Bölüm eklendikten sonra listeleme kısmını inceleyelim.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/195752b7-7268-4662-bb5f-d12740253952)

Bu kısımda da eklediğimiz, güncellediğimiz tüm bölümlerin listesini görebiliriz.

Öğrenci Kayıt İşlemi
![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/69659840-3103-4568-881c-a285a1a3eb0d)


Uygulamalar

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/4949d6ad-f779-4ef3-85a4-630954441a90)

Bu kısımda yönetici şifre değişikliği yapabilir, dil değiştirebilir veya diğer eğlence araçları olarak radyo, müzik dinleyebilir, gazete okuyabilir veya direkt bu panelden hesap makinesini açabilir.

Raporlar

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/2b7b38e7-13c9-4c11-8343-06ab80c947f4)

Raporlar kısmında ise burada öğrenci, akademisyen gibi isimleri alfabetik sırada gösterebilir, öğrenci, ders sayılarını gösterebilir veya şu ana kadar en son kaydedilen verileri Excel formatında kaydedebilir.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/50d88fe1-491f-40bb-bd28-69f9d67b40c0)

İkinci giriş panelimiz olan Akademisyen Paneli'nde daha önce yöneticinin kaydettiği akademisyenlerden birisi giriş yapabilir. Bu kısımda dil olarak İngilizce'yi seçtim. 

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/54e6446b-0f66-4bb1-b083-335107bb50d4)

Bu panelde akademisyen şifresini unutabilir. Forgot my Password seçeneğine tıklayarak akademisyene ait olan bilgileri girip yeni bir şifre oluşturabilir.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/b3bc1cd3-c072-43ce-8ea3-6febddf24ff6)

Akademisyen panelimiz bu şekilde karşımıza çıkmaktadır. Giriş yapak akademisyene göre adı, soyadı ve bölümü çıkmaktadır. Burada bölümün Türkçe olmasının sebebi SQL'e "Yönetim Bilişim Sistemleri" olarak kaydettiğimiz için bu şekilde çıkmaktadır. Bu panelde akademisyen ders ekleme, silme işlemlerini yapabilir, yalnızca bu bölüme ait olan öğrencilere not işlemleri yapabilir. Duyuru oluşturabilir.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/fc716f44-2abb-4cb4-b869-d97566ecb5b8)

Toplamda 13 ders olmasına rağmen yalnızca kendisine ait olan dersleri ekleme, silme veya güncelleme işlemleri yapabilir. YELİZ ASYA adlı akademisyenin sadece 4 dersi bulunmaktadır. Ders listesine tıkladığımız zaman bütün dersler gözükecektir.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/562c2a23-870e-4332-8ffc-919161cad582)

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/d0b044d7-2959-45c6-995b-d56e7b4aead5)

Not girişi panelinde ise akademisyen sadece kendisine ait olan ders seçerek öğrencinin notunu girebilir. Burada öğrenci girişini ID olarak ekledim. Sağında bulunan ... işaretine tıklandığı zaman o bölüme ait olan öğrenciler görünecektir. Uygulamalar kısmı ise Yönetici Paneli'nde olduğu gibidir.

En son giriş paneli ise Öğrenci Paneli'dir. Yöneticinin daha önceden eklemiş olduğu öğrenciler bu panelde giriş yapabileceklerdir.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/d2fae093-f06f-4836-9fce-d6dc77235b02)

Öğrenci Paneli giriş ekranı bu şekildedir.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/b9f930e1-7779-4e42-adc4-90654c487f7d)

Öğrenci panelde ise kendi sınav notlarını görebilir. Burada To Do List işlemleri de yapabilir. Her öğrenci sadece kendi yapılacaklar listesini görebilmektedir, duyuruları görebilmektedir veya Yönetici ve Akademisyen'de olduğu gibi Uygulamalar'da yer alan radyo, müzik dinleme seçeneklerini seçebilir.

![image](https://github.com/SercanKurban96/Education-Automation-System-Final-Case/assets/115387811/b4789895-29f4-4a85-aa0d-c504fd3d2720)

Burada öğrenci kendi notunu görüntüleyebilir.


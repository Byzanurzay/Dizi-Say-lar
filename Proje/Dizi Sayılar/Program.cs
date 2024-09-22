        Random random = new Random(); // Rastgele sayı oluşturmak için random sınıfı oluşturur
        
        int diziBoyutu = random.Next(10, 21); //Dizi boyutunun 10 ile 20 arasında olabilmesi için Random.Next kullanılarak 10 dahil olacak ama 21 olmayacak şekilde 10-20  elemanlı bir dizi boyutu oluşturur.
        int[] sayilar = new int[diziBoyutu]; //Bir tam sayı dizisi oluşturur ve boyutunu diziBoyutu değişkenine ayarlar

        int sayac = 0; //Dizide ki elemanlara sayı atamak ve saymak içın kullanılır

        while (sayac < diziBoyutu)
        {
            int yeniSayi = random.Next(0, 101); //0 ile 100 arasında rastegele sayılar oluşturur
            if (Array.IndexOf(sayilar, yeniSayi) == -1) //Yeni sayının dizide bulunup bulunmadıpını kontrol eder. -1 gelirse, yeni sayıyı sayilar dizisine atar
            {
                //sayılar dizinde yeni sayıya bir numara belirler, ve bunu devam ettirebilmek için her döngüde sayac değişkenini bir artırır
                sayilar[sayac] = yeniSayi; 
                sayac++;
            }
        }

        Console.WriteLine($"Dizinin eleman sayısı: {sayilar.Length}"); //Sayılar dizisinin uzunlupunu ekrana yazdırır
        Console.Write("Dizinin elemanları: "); //Dizinin elemalarını yazdırır
        for (int i = 0; i < sayilar.Length; i++) //i yi sıfırdan başlatarak sayilar dizisinde ki elemanları, teker teker ekrana ayzdırmak için kullanılıyor,
        {
            Console.Write(sayilar[i]); //i nin olduğu depere ait sayılar ekrana yazdırılır
            if (i < sayilar.Length - 1) //dizinin son elamanı ardından virgül eklenmemesi için kontrol yapar
                Console.Write(", "); //virgül ve boşluk koyar
        }
        Console.WriteLine(); //Boş satır yazdırır

        int minumum = sayilar[0]; //minumum sayıyı başlangıçta 0 alır
        int maksimum = sayilar[0]; //maksimum sayıyı başlangıçta 0 alır

        foreach (int sayi in sayilar) //Foreach ile sayılar dizisindeki elemanları sayi değeri adında döndürerek min ya da maks sayının dizide ki hangi sayı olduğunu kontrol etmek için kullanılır
        {
            if (sayi < minumum) //sayı minumum'un güncel değerinden küçükse;
            {
                minumum = sayi; //minumumu sayi değerine eşitler
            }
            if (sayi > maksimum) //sayı maksimum'un güncel değerinden büyükse;
            {
                maksimum = sayi; //maksimumu sayi değerine eşitler
            }
        }

        Console.WriteLine($"Dizideki En Küçük Sayı: {minumum}"); //Ekrana minumum, yani en küçük sayıyo yazdırır
        Console.WriteLine($"Dizideki En Büyük Sayı: {maksimum}"); //Ekrana maksimum, en büyük sayıyı yazdırır


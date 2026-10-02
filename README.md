# Basic. Ketma-ketlik — 1-amaliy vazifa (C# / .NET 8)

Mohirdev praktikumi uchun konsol dastur. Ishga tushirgach, vazifa raqamini (1, 2 yoki 3) tanlang.

```bash
dotnet run
```

| # | Vazifa | Fayl | Formula |
|---|--------|------|---------|
| 1 | Doira yuzi va aylana uzunligi | `Doira.cs` | `S = π·r²`, `L = 2·π·r` |
| 2 | Valyuta konvertori | `Valyuta.cs` | `natija = qiymat · kurs` |
| 3 | Yoshni kunlarda hisoblash | `Yosh.cs` | `(joriy yil − x) · 365` |

## Namuna

```
radius=3        ->  S=28.2743338823081, L=18.8495559215388
radius=4.23     ->  S=56.2122031914168, L=26.5778738493697
qiymat=2,   kurs=12400  ->  24800 so'm
qiymat=7.6, kurs=12400  ->  94240 so'm
x=2004  ->  (joriy yil − 2004) · 365   (2023-yilda: 6935)
x=1996  ->  (joriy yil − 1996) · 365   (2023-yilda: 9855)
```

> 3-vazifada joriy yil `DateTime.Now.Year` orqali olinadi. Topshiriqdagi namunalar 2023-yil uchun hisoblangan.

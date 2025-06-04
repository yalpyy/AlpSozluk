# AlpSozluk (Geliştirmeye devam edilen proje)



# Sözlük Platformu (Blazor + .NET 6)

Bu proje, Ekşi Sözlük, Uludağ Sözlük gibi platformlara benzer şekilde kullanıcıların entry (girdi) paylaşabildiği, konu başlıkları (title) açabildiği modern bir sözlük uygulamasıdır. Proje, **Blazor WebAssembly**, **.NET 6**, **Entity Framework 6**, **RabbitMQ** gibi güncel teknolojiler ile **CQRS**, **MediatR**, **Onion Architecture** gibi sağlam yazılım mimarileri kullanılarak geliştirilmektedir.

---

## 🚀 Proje Özellikleri

- 🧑‍💻 Blazor WebAssembly ile modern, interaktif ve component-tabanlı frontend
- ⚙️ .NET 6 tabanlı, katmanlı mimari
- 🧅 Onion Architecture ile bağımsız, sürdürülebilir yapı
- 💬 MediatR ile gevşek bağlı (loosely coupled) komut ve sorgu yönetimi
- 📬 RabbitMQ üzerinden Event Driven mimari
- 📂 CQRS (Command and Query Responsibility Segregation) yaklaşımı
- 🗃️ Entity Framework 6 ile Code First veri yönetimi
- 🔐 JWT ile kullanıcı kimlik doğrulama ve yetkilendirme
- 🌐 RESTful API desteği
- 📝 Entry ve Başlık sistemi
- 👍 Entry up/down vote, favorite sistemi
- 🔎 Gelişmiş arama ve filtreleme
- 📈 Skalalanabilir altyapıya uygun mimari

---

## 🧱 Kullanılan Teknolojiler

| Katman        | Teknoloji                                                                 |
|---------------|---------------------------------------------------------------------------|
| Frontend      | Blazor WebAssembly, MudBlazor (veya Telerik, Radzen vs.)                  |
| Backend       | .NET 6, ASP.NET Core Web API                                              |
| ORM           | Entity Framework 6 (Code First)                                           |
| Messaging     | RabbitMQ                                                                  |
| Authentication| JWT Bearer Token                                                          |
| Design Pattern| CQRS, Mediator, Onion Architecture                                        |
| Diğer         | AutoMapper, FluentValidation, Serilog, Swagger (API Dokümantasyon)        |

---

## 📂 Proje Yapısı

/src
├── Dictionary.API → API Gateway / Backend entry point
├── Dictionary.Application → CQRS komut ve sorgular, handler'lar
├── Dictionary.Domain → Entity tanımları, enumlar, domain servisleri
├── Dictionary.Infrastructure → DB erişimi, servis implementasyonları
├── Dictionary.Persistence → EF DbContext ve repository implementasyonu
├── Dictionary.WebApp → Blazor WebAssembly frontend
└── Dictionary.Common → Ortak modeller, mesajlar, utility'ler


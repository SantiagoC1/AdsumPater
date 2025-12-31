# Adsum Pater - Web de Misión Universitaria

Plataforma digital para la misión universitaria **Adsum Pater** del Movimiento de Schoenstatt (Diócesis de La Plata). Este proyecto busca conectar a la comunidad, difundir la misión y ofrecer un espacio espiritual digital.

## 🌟 Sobre el Proyecto

[cite_start]**Adsum Pater** es una misión-retiro universitaria que se realiza en Semana Santa, donde jóvenes universitarios dedican 4 días al servicio, la caridad y la fraternidad en distintos pueblos de la Provincia de Buenos Aires[cite: 10, 11, 13].

El objetivo de esta web es visibilizar la vida de la misión, facilitar la logística de las inscripciones y, fundamentalmente, crear un espacio de **comunidad y oración** a través de un foro interactivo.

## 🚀 Funcionalidades Principales

Basado en la estructura planificada, la web cuenta con los siguientes módulos:

### 1. Difusión e Identidad
* [cite_start]**Home:** Presentación del carisma "Adsum Pater" (Aquí estoy, Padre) y video/imágenes de impacto[cite: 104, 107].
* [cite_start]**Historia Interactiva:** Línea de tiempo con las misiones pasadas (desde 2006 en adelante: Castelli, Verónica, Bavio, etc.)[cite: 46, 48, 174].
* [cite_start]**El Pueblo:** Información sobre la localidad a visitar (mapa, historia, necesidades y cronograma)[cite: 156, 163].
* [cite_start]**Equipo:** Presentación de coordinadores y áreas (liturgia, cocina, difusión, etc.)[cite: 143, 146].

### 2. Comunidad y Espiritualidad (Foro)
[cite_start]Esta es una sección central para la interacción espiritual[cite: 190]:
* **Muro de Intenciones:** Los usuarios pueden subir sus intenciones de oración.
* [cite_start]**Botón "Rezo por vos":** Funcionalidad para que otros usuarios indiquen que están rezando por una intención específica[cite: 193].
* [cite_start]**Reflexiones:** Espacio para subir meditaciones, homilías breves, lecturas recomendadas y material espiritual[cite: 194, 196].

### 3. Gestión
* [cite_start]**Inscripciones:** Formulario y requisitos para sumarse a la misión[cite: 215].
* [cite_start]**Contacto:** Enlaces a redes sociales y contacto directo con el santuario[cite: 226].

## 🛠 Arquitectura Técnica

La solución sigue una **Arquitectura Limpia (Clean Architecture)** construida sobre **.NET 8/9** con Blazor.

* `AdsumPater.Core`: Contiene las entidades del dominio (ej: `Intencion`, `Reflexion`, `Misionero`) y las interfaces.
* `AdsumPater.Infrastructure`: Implementación de acceso a datos (Entity Framework) y servicios externos.
* `AdsumPater.Server`: La aplicación web principal (Blazor Web App) y API.

## 💻 Cómo ejecutar el proyecto

Requisitos: .NET SDK 8.0 o superior.

1.  **Clonar el repositorio:**
    ```bash
    git clone [https://github.com/SantiagoC1/AdsumPater.git](https://github.com/SantiagoC1/AdsumPater.git)
    ```
2.  **Navegar a la carpeta del servidor:**
    ```bash
    cd AdsumPater/AdsumPater.Server
    ```
3.  **Ejecutar la aplicación:**
    ```bash
    dotnet watch
    ```

## 🤝 Contribución

Este proyecto es mantenido por la comunidad universitaria de Schoenstatt La Plata. Las "Pull Requests" son bienvenidas para mejorar las funcionalidades del foro o la galería.

---
[cite_start]*"Si Padre: sí me animo, sí quiero, sí confío, sí creo y sí lo comparto."* [cite: 18]
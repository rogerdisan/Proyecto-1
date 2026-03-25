# Simulador de Decisiones - Plataforma de Streaming

## Descripción del sistema

Este programa simula la consola de decisiones de una plataforma de streaming. Su función es ayudar al equipo editorial a decidir qué contenidos pueden publicarse cada semana, evaluando cada solicitud de forma individual según reglas técnicas definidas.

El sistema analiza cada contenido ingresado y emite una de tres decisiones posibles:
- **PUBLICAR** — el contenido cumple todas las reglas y tiene impacto Bajo o Medio
- **ENVIAR A REVISIÓN** — cumple las reglas pero tiene impacto Alto
- **RECHAZAR** — incumple alguna regla técnica obligatoria

Al finalizar la sesión, el sistema muestra un resumen con estadísticas generales de todas las evaluaciones realizadas.

## Explicación del proyecto

El objetivo fue demostrar el uso correcto de las siguientes estructuras de programación en C#:

| Estructura  Uso en el proyecto 

| `switch`  Menú principal 
| `do-while`  Mantener el sistema activo hasta elegir Salir 
| `while`  Validación de entradas del usuario 
| `for`  Mostrar las secciones de reglas del sistema 
| `if/else` encadenado  Validación técnica y clasificación de impacto 
| `if` anidado  Reglas de horario por clasificación 
| Funciones  Todo el código está organizado en funciones separadas 
| `ref`  Pasar la razón de rechazo entre funciones 

El programa no utiliza arreglos ni listas para almacenar contenidos — cada evaluación se procesa en el momento y solo se mantienen contadores globales de estadísticas

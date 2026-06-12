# Parte 1 - Investigacion Teorica

**Nombre:** MArco David Mérida Velásquez

**Carnet:** 202500065

## 1. Estructuras de Datos Eficientes

### Arboles Binarios de Busqueda (ABB)

Un Arbol Binario de Busqueda es una estructura donde cada nodo cumple una regla de orden:

- Los valores menores al nodo actual se colocan en el subarbol izquierdo.
- Los valores mayores al nodo actual se colocan en el subarbol derecho.

Gracias a esta organizacion, es posible buscar elementos de forma mas rapida que en una lista lineal, siempre que el arbol conserve una forma equilibrada.

La principal desventaja aparece cuando los datos se insertan en orden secuencial, por ejemplo `1, 2, 3, 4, 5`. En ese caso, el arbol se degenera y toma una forma parecida a una lista enlazada, haciendo que la busqueda, insercion y eliminacion dejen de ser eficientes y puedan pasar a un costo cercano a `O(n)`.

### Arboles AVL

Un arbol AVL es un arbol binario de busqueda auto-balanceado. Esto significa que, despues de cada insercion o eliminacion, el arbol intenta mantener sus ramas con alturas similares para evitar degenerarse.

Su funcionamiento se apoya en el factor de balanceo:

`Factor = AlturaIzquierda - AlturaDerecha`

Para que un arbol AVL se considere balanceado, el factor de balanceo de cada nodo debe mantenerse normalmente entre `-1`, `0` y `1`. Cuando un nodo sale de ese rango, el arbol realiza rotaciones para corregir su estructura.

Gracias a ese balanceo automatico, la altura del arbol se mantiene controlada, por lo que las operaciones de busqueda, insercion y eliminacion conservan una complejidad de `O(log n)`.

## 2. Fundamentos de Web APIs

### Que es una API y como funciona el modelo Cliente-Servidor

Una API (Application Programming Interface) es un mecanismo que permite que dos sistemas se comuniquen entre si mediante reglas definidas. En una Web API, un cliente realiza solicitudes a un servidor para consultar, crear o modificar informacion.

En el modelo Cliente-Servidor:

- El cliente puede ser un navegador, Postman, una app movil o cualquier programa que consuma el servicio.
- El servidor recibe la peticion, la procesa y devuelve una respuesta.

La comunicacion normalmente viaja por HTTP. El cliente envia un `Request` que incluye:

- Un metodo HTTP como `GET` o `POST`.
- Una URL que identifica el recurso.
- Encabezados con informacion adicional.
- Opcionalmente, un cuerpo con datos.

El servidor procesa esa peticion y responde con un `Response` que incluye:

- Un codigo de estado, por ejemplo `200 OK` o `201 Created`.
- Encabezados.
- Un cuerpo, generalmente en formato JSON.

### Verbos HTTP

#### GET

`GET` se utiliza para recuperar recursos existentes. Su objetivo es consultar informacion sin modificar el estado del servidor.

Es un metodo idempotente porque, si se realiza varias veces la misma peticion `GET`, el resultado esperado es el mismo mientras los datos no hayan cambiado.

#### POST

`POST` se utiliza para crear nuevos recursos o enviar informacion para ser procesada por el servidor.

No se considera idempotente porque enviar la misma peticion varias veces puede generar varios recursos nuevos o repetir una operacion.

## Diferencia conceptual entre GET y POST

- `GET` consulta informacion.
- `POST` crea o envia informacion para producir un cambio en el servidor.

El uso correcto es emplear `GET` cuando solo se desea leer datos y `POST` cuando se desea registrar o insertar nuevos elementos.

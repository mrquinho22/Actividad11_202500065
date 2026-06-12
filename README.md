# Actividad 11 - Parte 2 y 3

## Implementacion realizada

Se desarrollo una Web API minimalista en ASP.NET Core para gestionar un catalogo de nodos en memoria.

### Recurso modelado

El recurso principal es `NodoElemento`, con las propiedades:

- `Id`: identificador numerico del nodo.
- `Valor`: descripcion o valor asociado al nodo.

### Endpoints implementados

- `GET /api/nodos`: retorna la coleccion actual de nodos.
- `POST /api/nodos`: inserta un nuevo nodo en la coleccion en memoria.

### Datos iniciales

La API inicia con estos nodos:

- `Id = 10`, `Valor = "Raiz Inicial (ABB)"`
- `Id = 5`, `Valor = "Hijo Izquierdo"`

### Validaciones agregadas

- No permite `Id` menor o igual a cero.
- No permite `Valor` vacio.
- No permite repetir un `Id` ya existente.

## Pruebas realizadas

### GET inicial

Se obtuvo `200 OK` con los dos nodos iniciales.

```json
[
  { "id": 10, "valor": "Raiz Inicial (ABB)" },
  { "id": 5, "valor": "Hijo Izquierdo" }
]
```

### POST de insercion

Se envio este JSON:

```json
{
  "id": 15,
  "valor": "Nuevo Nodo Derecho"
}
```

Resultado esperado y validado: `201 Created`.

### GET final

Despues del `POST`, la coleccion incluye el nuevo nodo.

## Ejecucion

Desde la carpeta `ApiEstructurasDemo`:

```bash
dotnet run
```

Luego probar en:

- `http://localhost:5259/api/nodos`

Tambien se incluye el archivo [ApiEstructurasDemo.http](ApiEstructurasDemo/ApiEstructurasDemo.http) para hacer las pruebas rapidamente.

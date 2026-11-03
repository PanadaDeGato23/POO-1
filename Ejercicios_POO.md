# Desarrollo de Videojuegos y Simulación Virtual
## Programación Orientada a Objetos (C#)
## Docente: Juan Carlos Gallardo

> 💡 Cada ejercicio trae una pista corta. Al final está la sección **"Soluciones de
> referencia"** con código completo (plegado con `<details>`). Intenta resolver primero
> sin mirarla.

> ⚠️ **Recordatorio:** todo script que use `Debug.Log` debe comenzar con `using UnityEngine;`.

---

## Bloque 1 — Clases, objetos y constructores (🟢 Básico)

**Ejercicio 1.** Crea una clase `NPC` con atributos públicos `nombre` (string), `dialogo`
(string) y `esComerciante` (bool). Agrega **un constructor** que reciba los tres valores y
los asigne (igual que el constructor de `Character`). Agrega un método `Hablar()` que
imprima el diálogo con `Debug.Log`. Instancia dos NPCs como campos públicos (igual que
`ClassManager` instancia `character`, `enemy`, etc.) y llama a `Hablar()` en cada uno desde
`Start()`.

💡 *Pista: sigue exactamente el mismo patrón que `Character`: atributos públicos +
constructor que los asigna uno a uno con `=`.*

**Ejercicio 2.** Crea una clase `Mision` con atributos `titulo`, `descripcion`,
`experienciaRecompensa` (int) y `completada` (bool). Agrega un constructor que reciba los
cuatro valores y un método `MostrarMision()` que imprima cada dato con `Debug.Log`.
Instancia dos misiones distintas y muestra ambas desde `Start()`.

💡 *Pista: compara con `Stats.cs` — una clase simple, con varios campos y un único
constructor que los asigna todos.*

---

## Bloque 2 — Herencia (🟢 Básico)

**Ejercicio 3.** Crea una clase base `Habilidad` con atributos `nombreHabilidad` (string) y
`costoMana` (int), más un constructor que los asigne. Crea una clase `FuegoHabilidad` que
herede de `Habilidad` (`: Habilidad`), agregue un atributo propio `daño` (int) y un
constructor que llame a `base(...)` para los dos atributos heredados.

💡 *Pista: sigue el mismo patrón que `Weapon : Item` — la clase hija agrega sus propios
atributos y su constructor usa `: base(...)` para los heredados.*

**Ejercicio 4.** Crea una segunda clase hija `HieloHabilidad : Habilidad` con un atributo
propio `duracionCongelado` (int) y su constructor con `base(...)`, igual que en el
Ejercicio 3.

💡 *Pista: así como `Item` tiene varias hijas (`Weapon`, `Armor`, `Accesory`), `Habilidad`
también puede tener más de una.*

---

## Bloque 3 — Polimorfismo con métodos virtuales (🟡 Intermedio)

**Ejercicio 5.** Convierte el método `MostrarHabilidad()` de `Habilidad` (agrégalo si no lo
tenías) en `virtual`, para que imprima `nombreHabilidad` y `costoMana`. En
`FuegoHabilidad`, sobrescríbelo con `override`, llamando primero a `base.MostrarHabilidad()`
y luego imprimiendo el atributo `daño`.

💡 *Pista: exactamente igual que `Weapon.ShowEquip()`, que llama a `base.ShowEquip()` y
después imprime `damage` y `element`.*

**Ejercicio 6.** Haz lo mismo en `HieloHabilidad`: sobrescribe `MostrarHabilidad()` llamando
a `base.MostrarHabilidad()` y agregando la impresión de `duracionCongelado`.

💡 *Pista: compara con `Armor.ShowEquip()`, que también llama a `base.ShowEquip()` y agrega
sus propios atributos (`defense`, `resistance`, `weight`).*

---

## Bloque 4 — Sobrecarga de métodos (🟢 Básico)

**Ejercicio 7.** En `Character.cs` ya existen dos sobrecargas de `WriteLine`:
`WriteLine(string,string)` y `WriteLine(string,int)`. Agrega una tercera sobrecarga
`WriteLine(string title, string value1, string value2)` que imprima el título junto a los
dos valores (por ejemplo, `"Rango: 1 - 10"`). Úsala en algún punto de `ShowData()`.

💡 *Pista: el nombre del método es el mismo; lo que cambia es la lista de parámetros
(cuántos son y de qué tipo).*

**Ejercicio 8.** Siguiendo el mismo patrón, agrega a la clase `Habilidad` (Bloque 2) dos
métodos sobrecargados: `Mostrar(string titulo, string valor)` y
`Mostrar(string titulo, int valor)`. Reemplaza los `Debug.Log` sueltos de
`MostrarHabilidad()` por llamadas a `Mostrar(...)`.

💡 *Pista: es el mismo mecanismo que `WriteLine` en `Character.cs`, aplicado a una clase
distinta.*

---

## Bloque 5 — Composición (🟡 Intermedio)

**Ejercicio 9.** Crea una clase `Mago` con atributo `nombre` (string) y un atributo
`habilidadPrincipal` de tipo `Habilidad`. El constructor de `Mago` debe recibir el nombre y
un objeto `Habilidad` ya creado y guardarlo en `habilidadPrincipal`.

💡 *Pista: igual que `Weapon` recibe un objeto `Element` ya construido en su constructor
(`Weapon(..., Element elem) : base(...) { element = elem; }`).*

**Ejercicio 10.** Crea una clase `Pocion` con atributo `nombrePocion` (string) y un atributo
`elementoAsociado` de tipo `Element` (la clase que ya existe en el proyecto). El
constructor de `Pocion` recibe el nombre y un `Element` ya creado.

💡 *Pista: reutiliza la clase `Element` tal como la usa `Weapon`; no crees una clase nueva
para el elemento.*

---

## Bloque 6 — Métodos propios de cada subclase (🟢 Básico)

**Ejercicio 11.** Agrega a `FuegoHabilidad` un método `Quemar()` que **no** exista en
`Habilidad` ni en `HieloHabilidad`, que imprima con `Debug.Log` un mensaje usando
`nombreHabilidad` y `daño`.

💡 *Pista: igual que `Weapon` tiene su propio método `Attack()` que no está en `Item` ni en
`Armor`/`Accesory`.*

**Ejercicio 12.** Agrega a `HieloHabilidad` un método `Congelar()` que **no** exista en
`Habilidad` ni en `FuegoHabilidad`, que imprima un mensaje usando `nombreHabilidad` y
`duracionCongelado`.

💡 *Pista: compara con `Armor.Equip()` y `Accesory.Use()` — cada subclase de `Item` tiene su
propio método adicional, distinto al de las demás.*

---

## Bloque 7 — Enumeraciones (🟢 Básico)

**Ejercicio 13.** El `enum elemento` dentro de `Element.cs` está declarado pero **nunca se
usa** (la clase sigue guardando `nameElement` como `string`). Corrígelo:
1. Haz el `enum` público.
2. Reemplaza el campo `nameElement` (string) por un campo `tipo` de tipo `elemento`.
3. Ajusta el constructor de `Element` para que reciba un `elemento` en vez de un `string`.
4. Ajusta `Weapon.cs`/`ClassManager.cs` donde se crean objetos `Element` para que pasen,
   por ejemplo, `elemento.Aire` en vez de `"Viento"`.

💡 *Pista: un `enum` privado dentro de una clase no es accesible desde otras clases; debe
declararse `public enum`.*

**Ejercicio 14.** Siguiendo el mismo patrón ya corregido en el Ejercicio 13, agrega a
`Habilidad` (Bloque 2) un `enum` propio `public enum TipoHabilidad { Fisica, Magica }` y un
campo `tipo` de ese tipo, asignado correctamente desde el constructor (sin repetir el error
original de `Element.cs`).

💡 *Pista: declara el `enum` como `public` dentro de `Habilidad` y agrega el parámetro al
constructor, igual que hiciste con `Element` en el ejercicio anterior.*

---

## Bloque 8 — Integración, estilo `ClassManager` (🟡 Intermedio)

**Ejercicio 15.** Crea una clase `HabilidadManager : MonoBehaviour`, siguiendo exactamente
el mismo estilo que `ClassManager.cs`: declara campos públicos que instancien un `NPC`
(Ejercicio 1), una `Mision` (Ejercicio 2), una `FuegoHabilidad` y una `HieloHabilidad`
(Bloques 2-4), directamente con `new` (sin arreglos ni listas). En `Start()`, llama a
`Hablar()`, `MostrarMision()`, `MostrarHabilidad()`, `Quemar()` y `Congelar()` en cada
objeto correspondiente.

💡 *Pista: copia la estructura de `ClassManager.cs` — campos públicos con `new` inline y un
`Start()` que llama a los métodos uno por uno.*

**Ejercicio 16.** Modifica el `ClassManager.cs` real del proyecto: agrega campos públicos
para un `Mago` y una `Pocion` (Bloque 5, con sus objetos `Habilidad`/`Element` ya
construidos) y llama a sus métodos desde `Start()`, junto a los objetos que ya existían.

💡 *Pista: no borres nada de lo que ya hay en `ClassManager.cs`; solo agrega los campos y
líneas nuevas, igual que si el proyecto fuera creciendo con más contenido.*

---

## Soluciones de referencia

> Despliega cada bloque para ver una solución posible. No son la única forma correcta de
> resolver el ejercicio — son una referencia para comparar tu propia solución.

<details>
<summary>💡 Solución Ejercicio 1 — NPC</summary>

```csharp
using UnityEngine;

public class NPC
{
    public string nombre;
    public string dialogo;
    public bool esComerciante;

    public NPC(string nombre, string dialogo, bool esComerciante)
    {
        this.nombre = nombre;
        this.dialogo = dialogo;
        this.esComerciante = esComerciante;
    }

    public void Hablar()
    {
        Debug.Log(nombre + ": " + dialogo);
    }
}

// En el manager:
// public NPC herrero = new NPC("Herrero", "¡Mira mis espadas!", true);
// public NPC aldeano = new NPC("Aldeano", "Lindo día, ¿no?", false);
//
// void Start() {
//     herrero.Hablar();
//     aldeano.Hablar();
// }
```
</details>

<details>
<summary>💡 Solución Ejercicio 2 — Mision</summary>

```csharp
using UnityEngine;

public class Mision
{
    public string titulo;
    public string descripcion;
    public int experienciaRecompensa;
    public bool completada;

    public Mision(string titulo, string descripcion, int experienciaRecompensa, bool completada)
    {
        this.titulo = titulo;
        this.descripcion = descripcion;
        this.experienciaRecompensa = experienciaRecompensa;
        this.completada = completada;
    }

    public void MostrarMision()
    {
        Debug.Log("Título: " + titulo);
        Debug.Log("Descripción: " + descripcion);
        Debug.Log("Recompensa: " + experienciaRecompensa);
        Debug.Log("Completada: " + completada);
    }
}
```
</details>

<details>
<summary>💡 Solución Ejercicios 3 y 4 — Habilidad, FuegoHabilidad, HieloHabilidad</summary>

```csharp
using UnityEngine;

public class Habilidad
{
    public string nombreHabilidad;
    public int costoMana;

    public Habilidad(string nombreHabilidad, int costoMana)
    {
        this.nombreHabilidad = nombreHabilidad;
        this.costoMana = costoMana;
    }
}

public class FuegoHabilidad : Habilidad
{
    public int daño;

    public FuegoHabilidad(string nombreHabilidad, int costoMana, int daño)
        : base(nombreHabilidad, costoMana)
    {
        this.daño = daño;
    }
}

public class HieloHabilidad : Habilidad
{
    public int duracionCongelado;

    public HieloHabilidad(string nombreHabilidad, int costoMana, int duracionCongelado)
        : base(nombreHabilidad, costoMana)
    {
        this.duracionCongelado = duracionCongelado;
    }
}
```
</details>

<details>
<summary>💡 Solución Ejercicios 5 y 6 — MostrarHabilidad() virtual/override</summary>

```csharp
public class Habilidad
{
    public string nombreHabilidad;
    public int costoMana;

    public Habilidad(string nombreHabilidad, int costoMana)
    {
        this.nombreHabilidad = nombreHabilidad;
        this.costoMana = costoMana;
    }

    public virtual void MostrarHabilidad()
    {
        Debug.Log("Nombre: " + nombreHabilidad);
        Debug.Log("Costo de maná: " + costoMana);
    }
}

public class FuegoHabilidad : Habilidad
{
    public int daño;

    public FuegoHabilidad(string nombreHabilidad, int costoMana, int daño)
        : base(nombreHabilidad, costoMana)
    {
        this.daño = daño;
    }

    public override void MostrarHabilidad()
    {
        base.MostrarHabilidad();
        Debug.Log("Daño: " + daño);
    }
}

public class HieloHabilidad : Habilidad
{
    public int duracionCongelado;

    public HieloHabilidad(string nombreHabilidad, int costoMana, int duracionCongelado)
        : base(nombreHabilidad, costoMana)
    {
        this.duracionCongelado = duracionCongelado;
    }

    public override void MostrarHabilidad()
    {
        base.MostrarHabilidad();
        Debug.Log("Duración congelado: " + duracionCongelado);
    }
}
```
</details>

<details>
<summary>💡 Solución Ejercicio 7 — Tercera sobrecarga de WriteLine</summary>

```csharp
public void WriteLine(string title, string value1, string value2)
{
    Debug.Log(title + ": " + value1 + " - " + value2 + ".");
}

// Uso dentro de ShowData():
// WriteLine("Rango", "1", "10");
```
</details>

<details>
<summary>💡 Solución Ejercicio 8 — Mostrar() sobrecargado en Habilidad</summary>

```csharp
public class Habilidad
{
    public string nombreHabilidad;
    public int costoMana;

    public Habilidad(string nombreHabilidad, int costoMana)
    {
        this.nombreHabilidad = nombreHabilidad;
        this.costoMana = costoMana;
    }

    public void Mostrar(string titulo, string valor)
    {
        Debug.Log(titulo + ": " + valor);
    }

    public void Mostrar(string titulo, int valor)
    {
        Debug.Log(titulo + ": " + valor);
    }

    public virtual void MostrarHabilidad()
    {
        Mostrar("Nombre", nombreHabilidad);
        Mostrar("Costo de maná", costoMana);
    }
}
```
</details>

<details>
<summary>💡 Solución Ejercicio 9 — Mago (composición con Habilidad)</summary>

```csharp
public class Mago
{
    public string nombre;
    public Habilidad habilidadPrincipal;

    public Mago(string nombre, Habilidad habilidadPrincipal)
    {
        this.nombre = nombre;
        this.habilidadPrincipal = habilidadPrincipal;
    }
}

// Uso:
// Habilidad bola = new FuegoHabilidad("Bola de fuego", 20, 35);
// Mago mago = new Mago("Pepito Mago", bola);
```
</details>

<details>
<summary>💡 Solución Ejercicio 10 — Pocion (composición con Element)</summary>

```csharp
public class Pocion
{
    public string nombrePocion;
    public Element elementoAsociado;

    public Pocion(string nombrePocion, Element elementoAsociado)
    {
        this.nombrePocion = nombrePocion;
        this.elementoAsociado = elementoAsociado;
    }
}

// Uso (con el Element ya existente en el proyecto):
// Element fuego = new Element("Fuego", "Calorcito");
// Pocion pocion = new Pocion("Pocion de Fuego", fuego);
```
</details>

<details>
<summary>💡 Solución Ejercicio 11 — Quemar() exclusivo de FuegoHabilidad</summary>

```csharp
public void Quemar()
{
    Debug.Log(nombreHabilidad + " quema al objetivo con " + daño + " de daño.");
}
```
</details>

<details>
<summary>💡 Solución Ejercicio 12 — Congelar() exclusivo de HieloHabilidad</summary>

```csharp
public void Congelar()
{
    Debug.Log(nombreHabilidad + " congela al objetivo por " + duracionCongelado + " turnos.");
}
```
</details>

<details>
<summary>💡 Solución Ejercicio 13 — Element.cs corregido (enum usado correctamente)</summary>

```csharp
using UnityEngine;

public class Element
{
    public enum elemento
    {
        Aire,
        Tierra,
        Fuego,
        Agua,
        Rayo,
        Hielo,
        Oscuridad,
        Luz
    }

    public elemento tipo;
    public string description;

    public Element(elemento tipo, string desc)
    {
        this.tipo = tipo;
        description = desc;
    }
}

// En Weapon.cs / ClassManager.cs, donde antes se escribía:
//   new Element("Viento", "Airesito")
// ahora se escribe:
//   new Element(Element.elemento.Aire, "Airesito")
```
</details>

<details>
<summary>💡 Solución Ejercicio 14 — TipoHabilidad en Habilidad</summary>

```csharp
public class Habilidad
{
    public enum TipoHabilidad { Fisica, Magica }

    public string nombreHabilidad;
    public int costoMana;
    public TipoHabilidad tipo;

    public Habilidad(string nombreHabilidad, int costoMana, TipoHabilidad tipo)
    {
        this.nombreHabilidad = nombreHabilidad;
        this.costoMana = costoMana;
        this.tipo = tipo;
    }
}

// Uso:
// Habilidad golpe = new Habilidad("Golpe", 5, Habilidad.TipoHabilidad.Fisica);
```
</details>

<details>
<summary>💡 Solución Ejercicio 15 — HabilidadManager</summary>

```csharp
using UnityEngine;

public class HabilidadManager : MonoBehaviour
{
    public NPC herrero = new NPC("Herrero", "¡Mira mis espadas!", true);
    public Mision mision = new Mision("Cazar goblins", "Elimina 5 goblins", 150, false);
    public FuegoHabilidad bolaDeFuego = new FuegoHabilidad("Bola de fuego", 20, 35);
    public HieloHabilidad rayoDeHielo = new HieloHabilidad("Rayo de hielo", 15, 2);

    void Start()
    {
        herrero.Hablar();
        mision.MostrarMision();
        bolaDeFuego.MostrarHabilidad();
        rayoDeHielo.MostrarHabilidad();
        bolaDeFuego.Quemar();
        rayoDeHielo.Congelar();
    }
}
```
</details>

<details>
<summary>💡 Solución Ejercicio 16 — ClassManager ampliado con Mago y Pocion</summary>

```csharp
// Dentro de la clase ClassManager ya existente, se agregan:

public Habilidad habilidadDelMago = new Habilidad("Toque arcano", 10);
public Mago mago = new Mago("Pepito Mago", new FuegoHabilidad("Bola de fuego", 20, 35));
public Element elementoPocion = new Element("Fuego", "Calorcito");
public Pocion pocionDeFuego = new Pocion("Pocion de Fuego", elementoPocion);

void Start()
{
    // ... llamados que ya existían (character.ShowData(), enemy.ShowData(), etc.)

    mago.habilidadPrincipal.MostrarHabilidad();
    Debug.Log(pocionDeFuego.nombrePocion + " - Elemento: " + pocionDeFuego.elementoAsociado.description);
}
```
</details>
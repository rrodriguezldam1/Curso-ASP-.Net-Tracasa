window.onload = function() {
    let btnAnadir = document.getElementById("btn-anadir");
    btnAnadir.onclick = function() {
        let campoNombre = document.getElementById("nombre");
        let nombre = campoNombre.value.toUpperCase();
        let edad = parseInt(document.getElementById("edad").value);
        let sigDecada = edad + 10;
        alert(`Iepa ${nombre} Tienes ${edad} y la sig decada ${sigDecada} !`);
    };
    document.getElementById("btn-ir").addEventListener("click", function()
    {
        window.location = document.getElementById("url").value;
    });
}
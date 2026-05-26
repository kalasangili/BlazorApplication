window.loadMap = function () {

    var map = L.map('map').setView([12.9716, 77.5946], 13);

    L.tileLayer(
        'https://tile.openstreetmap.org/{z}/{x}/{y}.png',
        {
            attribution: '&copy; OpenStreetMap contributors'
        }
    ).addTo(map);

L.marker([12.9716, 77.5946])
    .addTo(map)
    .bindPopup("Bangalore")
        .openPopup();

}

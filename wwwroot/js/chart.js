window.createProductChart = (products) => {
    const ctx = document.getElementById('productChart').getContext('2d');
    const labels = products.map(p => p.name);
    const data = products.map(p => p.price);

    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Цены продуктов',
                data: data,
                backgroundColor: 'rgba(75, 192, 192, 0.2)',
                borderColor: 'rgba(75, 192, 192, 1)',
                borderWidth: 1,
            }]
        },
        options: {
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
};

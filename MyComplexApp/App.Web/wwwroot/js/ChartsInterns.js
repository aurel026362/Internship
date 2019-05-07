var ctx = document.getElementById('mychart').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'pie',
    data: {
        labels: ['Ion Vrisa', 'Alexandru Vascor', 'Evghenii Durin',
            'Dumitru Diaconu', 'Gherghe Chiet', 'Nicolae Holvan'],
        datasets: [{
            label: '# of Votes',
            data: [7.8, 6.4, 8.9, 7.75, 8.4, 6.7],
            backgroundColor: [
                'blue',
                'red',
                'green',
                'gray',
                'yellow',
                'purple'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(52,143,236,1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    }
});
var ctx = document.getElementById('mychart2').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: ['Ion Vrisa', 'Alexandru Vascor', 'Evghenii Durin',
            'Dumitru Diaconu', 'Gherghe Chiet', 'Nicolae Holvan'],
        datasets: [{
            label: '# of Votes',
            data: [7.8, 6.4, 8.9, 7.75, 8.4, 6.7],
            backgroundColor: [
                'blue',
                'red',
                'green',
                'gray',
                'yellow',
                'purple'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(52,143,236,1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    }
});
var ctx = document.getElementById('mychart3').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ['Ion Vrisa', 'Alexandru Vascor', 'Evghenii Durin',
            'Dumitru Diaconu', 'Gherghe Chiet', 'Nicolae Holvan'],
        datasets: [{
            label: '# of Votes',
            data: [7.8, 6.4, 8.9, 7.75, 8.4, 6.7],
            backgroundColor: [
                'blue',
                'red',
                'green',
                'gray',
                'yellow',
                'purple'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(52,143,236,1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    }
});
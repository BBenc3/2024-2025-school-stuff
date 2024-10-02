// Belső állapot
let state = {
  circle: 0,
  square: 0,
  rectangle: 0,
};


// 1. Selecteld ki id alapján a form elementet és submit eseményre 
// köss be funkcionalitást
document.getElementById('shapes').addEventListener('submit', (event) => {
  event.preventDefault();
  let shape = event.target.elements.selectedShape.value
  let action = event.target.elements.action.value

  if (action === 'increment') {
    state[shape]++
  }
  if (action === 'decrement') {
    state[shape]--
  }

  render()
})

function render() {
  let circle = document.getElementById('sh-circle')
  let square = document.getElementById('sh-square')
  let rectangle = document.getElementById('sh-rectangle')

  circle.innerHTML = state.circle
  square.innerHTML = state.square
  rectangle.innerHTML = state.rectangle
}

// 2. Az esemény bekövetkezésekor olvasd ki az input mezőkben lévő adatokat

// 3. Az adatok alapján módosítsd az alkalmazás belső állapotát

// 4. A belső állapot alapján rajzold újra a formákat

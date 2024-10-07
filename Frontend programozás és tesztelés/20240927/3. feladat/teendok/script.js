let state = {
  teendok: [],
  isPending: false,
};

// 1. Kattintás eseményre köss be funkcionalitást
document.getElementById('fetch-btn').addEventListener('click', () => {
  state.isPending = true;
  fetch('https://jsonplaceholder.typicode.com/todos')
    .then(response => response.json())
    .then(data => {
      state.teendok = data.filter(todo => todo.userId === 1);
      state.isPending = false;
      render();
    });
})

function render() {
  const list = document.getElementById('todo-list');
  list.innerHTML = '';
  if (state.isPending) {
    list.innerHTML = 'Betöltés folyamatban...';
  } else {
    for (const todo of state.teendok) {
      const li = document.createElement('li');
      li.textContent = todo.title;
      list.appendChild(li);
    }
  }
}


// 2. A esemény bekövetkezésekor állítsd a state isPending értékét true-ra

// 3. Küldj AJAX kérést a beépített "fetch" függvény segítségével

// 4. A válaszként kapott adatokat szűrd meg a "filter" függvénnyel

// 5. A megszűrt adatokat írd be a state teendok kulcsa alá

// 6. Ezután állítsd vissza az isPending-et false-ra

/* 7. Készíts egy renderelő függvényt, ami
  - Ha az isPending true, akkor egy "Betöltés folyamatban" feliratot ír ki
  - Ha az isPending false, akkor pedig kirajzolja az összes teendőt, 
    ami a state-ben van
*/

// 8. Hívd meg a renderelő függvényt a 2. és az 4. pont után is

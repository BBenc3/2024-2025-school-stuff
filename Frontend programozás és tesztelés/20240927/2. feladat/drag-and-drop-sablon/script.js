let draganddrop = document.getElementById('drag-and-drop-app');
let state = {
  elemek: { 
    "elso":{
      id: "elso",
      x: draganddrop.offsetLeft,
      y: draganddrop.offsetTop,
    },
    "masodik":{
      id: "masodik",
      x:  draganddrop.offsetLeft + 20,
      y: draganddrop.offsetTop + 150,
      },
    "harmadik":{
      id: "harmadik",
      x:  draganddrop.offsetLeft + 40,
      y: draganddrop.offsetTop + 300,
      }
  },
  draggedID: undefined,
};


state.x = draganddrop.offsetLeft;
state.y = draganddrop.offsetTop;
onload = () => {
  render();
}


// 1. Készíts renderelő függvényt, ami megjeleníti a dobozt a state-ből kiolvasott adatok alapján
function render() {
  for (const element of Object.values(state.elemek)) {
    let box = document.createElement('div');
    box.style.width = "50px";
    box.style.height = "50px";
    box.style.backgroundColor = "red";
    box.id = element.id;
    box.style.position = "absolute";
    box.style.left = element.x + "px";
    box.style.top = element.y + "px";
    box.addEventListener('mousedown', (event) => {
      state.draggedID = element.id;
    });
    box.addEventListener('mouseup', (event) => {
      state.draggedID = undefined;
    });
    box.addEventListener('mousemove', (event) => {
      if (state.draggedID === element.id) {
        state.elemek[state.draggedID].x = event.clientX - box.offsetWidth / 2;
        state.elemek[state.draggedID].y = event.clientY - box.offsetHeight / 2;
        draganddrop.innerHTML = "";
        render();
      }
    });
    draganddrop.appendChild(box);
  }
  
}
// 2. A dobozt úgy rajzold ki, hogy az element-nek a position style attribútuma "absolute", a 
//    left és a top attribútuma pedig a state-ből származó x és y érték

// 3. A doboz mousedown eseményre reagálva módosítsd a state isDragged értékét true-ra

// 4. A doboz mouseup és mouseleave eseményre reagálva módosítsd a state isDragged értékét false-ra

/* 5. A doboz mousemove eseménykor vizsgáld meg, hogy a state.isDragged értéke true-e
Amennyiben igen, írd be a state x és y kulcsa alá az egér aktuális x,y pozícióját */

// 7. Az állapotváltozások után hívd meg a renderelő függvényt

      // Um array para armazenar todas as reservas
      let reservas = [];

      function makeReservation() {
        // Obtém os valores dos campos de formulário
        let name = document.getElementById("name").value;
        let email = document.getElementById("email").value;

        // Adiciona a nova reserva ao array
        reservas.push({ name, email });

        // Atualiza a lista de reservas na página
        updateReservasList();
      }

      function updateReservasList() {
        // Obtém o elemento da lista de reservas
        let reservasList = document.getElementById("reservas-list");

        // Limpa a lista de reservas antiga
        reservasList.innerHTML = "";

        // Adiciona todas as reservas ao HTML da lista
        for (let i = 0; i < reservas.length; i++) {
          let reservation = reservas[i];
          reservasList.innerHTML += "<li>" + reservation.name + " at " + reservation.email + "</li>";
        }
      }
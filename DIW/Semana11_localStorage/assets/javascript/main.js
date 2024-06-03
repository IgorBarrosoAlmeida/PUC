    document.addEventListener("DOMContentLoaded", function() {
        loadTasks();
    });

    function addTask() {
        var input = document.getElementById("taskInput");
        var taskText = input.value.trim();
        if (taskText === "") return;

        var tasks = JSON.parse(localStorage.getItem("tasks")) || [];
        tasks.push({ text: taskText, completed: false });
        localStorage.setItem("tasks", JSON.stringify(tasks));

        input.value = "";
        loadTasks();
    }

    function removeTask(index) {
        var tasks = JSON.parse(localStorage.getItem("tasks")) || [];
        tasks.splice(index, 1);
        localStorage.setItem("tasks", JSON.stringify(tasks));
        loadTasks();
    }

    function toggleTask(index) {
        var tasks = JSON.parse(localStorage.getItem("tasks")) || [];
        tasks[index].completed = !tasks[index].completed;
        localStorage.setItem("tasks", JSON.stringify(tasks));
        loadTasks();
    }

    function loadTasks() {
        var tasks = JSON.parse(localStorage.getItem("tasks")) || [];
        var list = document.getElementById("taskList");
        list.innerHTML = "";

        tasks.forEach(function(task, index) {
            var listItem = document.createElement("li");
            listItem.className = "task-item";
            if (task.completed) {
                listItem.classList.add("completed");
            }

            var checkbox = document.createElement("input");
            checkbox.type = "checkbox";
            checkbox.checked = task.completed;
            checkbox.addEventListener("change", function() {
                toggleTask(index);
            });

            var taskText = document.createElement("span");
            taskText.textContent = task.text;

            var removeButton = document.createElement("button");
            removeButton.textContent = "Remover";
            removeButton.addEventListener("click", function() {
                removeTask(index);
            });

            listItem.appendChild(checkbox);
            listItem.appendChild(taskText);
            listItem.appendChild(removeButton);
            list.appendChild(listItem);
        });
    }
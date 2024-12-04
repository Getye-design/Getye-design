// This function retrieves the list of tasks from local storage
function get_todos() {
    /* This creates an array of tasks that are inputted */
    var todos = new Array();
    /* This pulls the task list that was saved in the web browser memory */
    var todos_str = localStorage.getItem('todo');
    /* If the input is not null, then parse it into a JavaScript object */
    if (todos_str !== null) {
        todos = JSON.parse(todos_str);
    }
    return todos;
}

// This function adds a new task to the to-do list
function add() {
    /* This takes the inputted task and creates a variable of it */
    var task = document.getElementById('task').value;

    /* Retrieve the existing tasks */
    var todos = get_todos();
    /* Add the new task to the end of the array */
    todos.push(task);
    /* Convert the task array into a JSON string and save it to local storage */
    localStorage.setItem('todo', JSON.stringify(todos));
    /* Clear the input field */
    document.getElementById('task').value = "";

    /* Display the updated task list */
    show();

    return false;
}

// This function keeps the tasks permanently displayed on the screen
function show() {
    /* Retrieve the task list as a variable */
    var todos = get_todos();

    /* Create an unordered list to display the tasks */
    var html = '<ul>';
    /* Loop through the task array and add each task as a list item */
    for (var i = 0; i < todos.length; i++) {
        /* Add the task to the list and include a remove button for each */
        html += '<li>' + todos[i] + '<button class="remove" id="' + i + '">x</button></li>';
    };
    html += '</ul>';

    /* Display the tasks as a list */
    document.getElementById('todos').innerHTML = html;
}

/* Attach an event listener to the 'Add Item' button */
document.getElementById('add').addEventListener('click', add);
/* Call the `show` function to ensure the tasks are displayed permanently */
show();

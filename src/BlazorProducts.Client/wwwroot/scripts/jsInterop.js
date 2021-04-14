export function showAlert(message) {
    alert(message);
}

export function showAlertObject(person) {
    alert(`Name: ${person.name} Email: ${person.email}`);
}

export function showPrompt(message) {
    var email = prompt(message);

    return email;
}

export function complexObject(message) {
    return {
        name: "Luru",
        email: "lruiz@plainconcepts.com"
    };
}

export function focusAndStyleElement(element) {
    element.style.color = 'red';
    element.focus();
}

export function focusAndStyleComponent(id) {
    const element = document.getElementById(id);

    element.style.color = 'red';
    element.focus();
}

export function throwError() {
    throw Error("Error from JS");
}
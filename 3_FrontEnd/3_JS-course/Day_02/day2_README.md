
# 📘 JavaScript Bootcamp – Day 2 Summary

Below is a structured list of all the practical files included in Day 2 with a short description of what you'll learn in each:

---

### `0.dark_mode_toggle.html`
- **Topic:** CSS class manipulation.
- **You will learn:** How to toggle between `.dark-mode` and `.light-mode` using JavaScript and `classList.add/remove`.

### `1.Loop.html`
- **Topic:** Basic loop with list rendering.
- **You will learn:** How to use a `for` loop to dynamically populate a list with numbers.

### `2.loop_example_table.html`
- **Topic:** Table + loop.
- **You will learn:** Creating a table and populating rows with calculated data using a loop.

### `3.loop_students_table.html`
- **Topic:** Looping through object arrays.
- **You will learn:** Creating a table from an array of student objects using `for` loop.

### `4.fetch_json_api.html`
- **Topic:** Fetch JSON from API and populate table.
- **You will learn:** How to use `fetch()` to retrieve JSON data and display it dynamically.

### `5.json_loop_section_exsist.html`
- **Topic:** JSON loop inside an existing section.
- **You will learn:** Looping through an array and injecting card-style content into a predefined section using its ID.

### `6.json_loop_section_Create.html`
- **Topic:** JSON loop with dynamic section creation.
- **You will learn:** Creating HTML elements dynamically for each JSON object and appending them to the DOM.

### `7.json_api_section.html`
- **Topic:** Fetching user data from public API and rendering it as card elements.
- **You will learn:** Working with APIs + DOM insertion inside a section using real remote data.


**Skills Gained:**
- Use of `array.filter()` or manual loops to show data based on user interaction
- Template rendering with `replace`
- Handling button clicks with `onclick`
- Working with structured JavaScript objects

**Files Used:**
- `our-menu.html` – HTML structure for the menu page
- `our-menu.css` – Styling for layout, cards, and filter buttons
- `our-menu.js` – Script that loops over menu items and filters them dynamically
---



## 🧪 Practical Tasks

### ✅ **Task 1 – Toggle a CSS Class**
**Objective:** Create a button that toggles a class on an element.
**Example:** Toggle `highlight` class on a paragraph to change its background color.
```javascript
document.getElementById("btn").addEventListener("click", () => {
  document.getElementById("para").classList.toggle("highlight");
});
```

---

### ✅ **Task 2 – Loop Through Student List and Show in Table**
**Objective:** Use a loop to display a list of students with name and grade in an HTML table.
**Example:**
```javascript
const students = [
  { name: "Ali", grade: 90 },
  { name: "Sara", grade: 85 },
  { name: "Omar", grade: 78 }
];

students.forEach(student => {
  console.log(`${student.name} got ${student.grade}`);
});
```
You can insert these into a table dynamically.


---

### ✅ **Task 3 – Display Data from Array**  
**Objective:** Use a local array of user objects (containing `name` and `email`) and display the data in an HTML table.

**Example:**
```javascript
const users = [
  { name: "Ali Ahmed", email: "ali@example.com" },
  { name: "Sara Mostafa", email: "sara@example.com" },
  { name: "Omar Khalid", email: "omar@example.com" }
];
```

You should loop through the array and insert each user into the table dynamically using JavaScript.

---

### ✅ **Task 4 – Get Data from Public API**
**Objective:** Use `fetch()` to get data from [https://fakestoreapi.com/products](https://fakestoreapi.com/products), and display each product (title, price, and image) inside a card layout in a section.

---

### 👨‍💻 Created by
**Mohamed Alswaify**

- 👤 **Author**: Mohamed Alswaify   
- 🌐 **Website**: [mohamed-alswaify.com](https://mohamed-alswaify.com)  
- 🔗 **GitHub**: [github.com/mohamedalswaify](https://github.com/mohamedalswaify)  
- 💼 **LinkedIn**: [linkedin.com/in/mohamedalswaify](https://linkedin.com/in/mohamedalswaify)  
- 💬 **WhatsApp**: [Chat on WhatsApp](https://wa.me/966564842804)  
- 📘 **Facebook**: [facebook.com/Mohamed-Alswaify](https://facebook.com/Mohamed-Alswaify)

---


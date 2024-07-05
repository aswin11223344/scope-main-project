const locations = {
    "India": {
        "Tamilnadu": ["Coimbatore", "Kanyakumari", "Tirunelveli"],
        "Kerala": ["Trivandrum", "Kochi", "Palakkad"]
    },
    "USA": {
        "Alabama": ["Birmingham", "Montgomery", "Mobile", "Huntsville"],
        "Alaska": ["Anchorage", "Fairbanks", "Juneau", "Sitka"]
    }
};

function updateStates() {
    const countrySelect = document.getElementById("country");
    const stateSelect = document.getElementById("state");
    const citySelect = document.getElementById("city");
    const selectedCountry = countrySelect.value;

   
    stateSelect.innerHTML = '<option value="" disabled selected>Select State</option>';
    citySelect.innerHTML = '<option value="" disabled selected>Select City</option>';

    if (selectedCountry in locations) {
        for (const state in locations[selectedCountry]) {
            const option = document.createElement("option");
            option.value = state;
            option.text = state;
            stateSelect.add(option);
        }
    }
}


function updateCities() {
    const countrySelect = document.getElementById("country");
    const stateSelect = document.getElementById("state");
    const citySelect = document.getElementById("city");
    const selectedCountry = countrySelect.value;
    const selectedState = stateSelect.value;

 
    citySelect.innerHTML = '<option value="" disabled selected>Select City</option>';


    if (selectedCountry in locations && selectedState in locations[selectedCountry]) {
        for (const city of locations[selectedCountry][selectedState]) {
            const option = document.createElement("option");
            option.value = city;
            option.text = city;
            citySelect.add(option);
        }
    }
}
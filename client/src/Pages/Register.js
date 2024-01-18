import { useEffect } from "react";
import React, { useState } from "react";
import { jwtDecode } from "jwt-decode";
import styles from '../styles/Register.module.css'
import GuestBar from './Bars/GuestBar';
import ContactGegevens from './Bars/ContactGegevensBar'


export default function GoogleLogin(){
  // var beperkingen = [
const [beperkingen, setBeperkingen] = useState([
  // {
  //   type: "test"
  // },
  // {
  //   type: "test2"
  // }
]);
const [hulpmiddelen, setHulpmiddelen] = useState([]);
const [inputValue, setInputValue] = useState('');
const [inputValue2, setInputValue2] = useState('');
    function displayFallBackImage() {
        // Use document.querySelector to find the element with the class 'userImg'
        var userImgElement = document.querySelector(".userImg");
    
        // Check if the element is found before trying to modify its 'src' property
        if (userImgElement) {
          userImgElement.src = "client/847969.png";
        }
      }
    
      const [user, setUser] = useState({});
    
      function handleCallbackResponse(response) {
        console.log("Encoded JWT ID token: " + response.credential);
        var userObject = jwtDecode(response.credential);
        console.log(userObject);
        setUser(userObject);
        document.getElementById("signInDiv").hidden = true;
      }
    
      function handleSignOutEvent(event) {
        setUser({});
        document.getElementById("signInDiv").hidden = false;
      }

      // function addbeperkingToList() {
      //   document.getElementsByClassName("beperking_input").color = "red";
      //   let beperking = document.getElementsByClassName("beperking_input").value;
      //   if (beperking) {
      //     beperking.push([{type: beperking}])
      //   }
      //   document.getElementsByClassName("beperking_input").value = "";
      // }
      function addbeperkingToList() {
        if (inputValue) {
          setBeperkingen(prevBeperkingen => [...prevBeperkingen, { type: inputValue }]);
          setInputValue('');
        }
      }

      // function addcustombeperkingToList(name) {
      //   console.log('Adding custom beperking to list:', name);
      //   setBeperkingen(prevBeperkingen => [...prevBeperkingen, name]);
      //   setInputValue('');
      // }

      function addhulpmiddelToList() {
        if (inputValue2) {
          setHulpmiddelen(prevHulpmiddelen => [...prevHulpmiddelen, { type: inputValue2 }]);
          setInputValue2('');
        }
      }

      // function RemoveBeperking(beperking) {
      //   var placeholderBeperkingen = [{}]
      //   for (let i = 0; i > beperkingen.length; i++) {
      //     if (beperkingen[i].type !== beperking.type && beperkingen[i].type !== "") {
      //       placeholderBeperkingen += beperkingen[i];
      //     }
      //   }
      //   beperkingen.join(placeholderBeperkingen);
      // }
      function RemoveBeperking(beperking) {
        const updatedBeperkingen = beperkingen.filter(item => item.type !== beperking.type && item.type !== "");
        setBeperkingen(updatedBeperkingen);
      }

      function RemoveHulpmiddel(hulpmiddel) {
        const updatedHulpmiddelen = hulpmiddelen.filter(item => item.type !== hulpmiddel.type && item.type !== "");
        setHulpmiddelen(updatedHulpmiddelen);
      }

      // function myFunction() {
      //   document.getElementById("myDropdown").classList.toggle("show");
      // }
      
      // // Close the dropdown if the user clicks outside of it
      // window.onclick = function(event) {
      //   if (!event.target.matches('.dropbtn')) {
      //     var dropdowns = document.getElementsByClassName("dropdown-content");
      //     var i;
      //     for (i = 0; i < dropdowns.length; i++) {
      //       var openDropdown = dropdowns[i];
      //       if (openDropdown.classList.contains('show')) {
      //         openDropdown.classList.remove('show');
      //       }
      //     }
      //   }
      // }

  //     const [selectedOption1, setSelectedOption1] = useState('');
  // const [selectedOption2, setSelectedOption2] = useState('');

  // const handleDropdownChange1 = (event) => {
  //   // setSelectedOption1(event.target.value);
  //   const selectedValue = event.target.value;
  //   if (selectedValue) {
  //     addcustombeperkingToList(String(selectedValue));
  //     setSelectedOption(selectedValue);
  //   }
  // };

  // const handleDropdownChange2 = (event) => {
  //   setSelectedOption2(event.target.value);
  // };

  // const menuButtons = [
  // ];

  // const filteredMenuButtons1 = menuButtons.filter(item => {
  //   const lowercasedSearchInput = selectedOption1.toLowerCase();
  //   return (
  //     (item.titel && item.titel.toLowerCase().includes(lowercasedSearchInput)) ||
  //     (item.beschrijving && item.beschrijving.toLowerCase().includes(lowercasedSearchInput)) ||
  //     (item.locatie && item.locatie.toLowerCase().includes(lowercasedSearchInput))
  //   );
  // });

  // const filteredMenuButtons2 = menuButtons.filter(item => {
  //   const lowercasedSearchInput = selectedOption2.toLowerCase();
  //   return (
  //     (item.titel && item.titel.toLowerCase().includes(lowercasedSearchInput)) ||
  //     (item.beschrijving && item.beschrijving.toLowerCase().includes(lowercasedSearchInput)) ||
  //     (item.locatie && item.locatie.toLowerCase().includes(lowercasedSearchInput))
  //   );
  // });

  // // Define the options for the dropdowns
  // const dropdownOptions1 = [
  //   { label: 'All', value: '' },
  //   { label: 'Option 1', value: 'option1' },
  //   { label: 'Option 2', value: 'option2' },
  //   // Add more options as needed
  // ];

  // const dropdownOptions2 = [
  //   { label: 'All', value: '' },
  //   { label: 'Option A', value: 'optionA' },
  //   { label: 'Option B', value: 'optionB' },
  //   // Add more options as needed
  // ];

      const [selectedOption, setSelectedOption] = useState(null);
      const handleBenaderingOptionChange = (event) => {
      setSelectedOption(event.target.value);
      };

      const [selectedCommercieleOption, setSelectedCommercieleOption] = useState(null);
      const handleCommercieelOptionChange = (event) => {
      setSelectedCommercieleOption(event.target.value);
      };
    
      useEffect(() => {
        /*global google*/
        google.accounts.id.initialize({
          client_id:
            "235973845509-5fddgbhrq2qs29am82tsr7unpch77gms.apps.googleusercontent.com",
          callback: handleCallbackResponse,
        });
        google.accounts.id.renderButton(document.getElementById("signInDiv"), {
          theme: "outline",
          width: 500,
        });
        /*global google*/
        google.accounts.id.prompt();
      }, []);

      const [checkedItems, setCheckedItems] = useState({}); // State to keep track of checked items

  const handleCheckboxChange = (event) => {
    setCheckedItems({
      ...checkedItems,
      [event.target.name]: event.target.checked,
    });
  };
    
      return (
        <>
        <GuestBar>
        </GuestBar>
        <img id={styles.wachtkamer_img} src="/Images/wachtkamer_plant.png" alt="Wachtkamer Achtergrond"/>
      <div>
        <h1 id={styles.login_title}>Registreer</h1>
        <div id={styles.blok_1}>


        {/* <div id="google_login" className={styles.google_login}>
          <div id="signInDiv" alt="Google Login"></div>
          {Object.keys(user).length !== 0 && (
            <button onClick={(e) => handleSignOutEvent(e)}>log uit</button>
          )}
    
          {user && (
            <div>
              <img
                className="userImg"
                src={user.picture}
                onError={displayFallBackImage()}
                alt="user-image"
              />
              <h3>{user.name}</h3>
            </div>
          )}
        </div> */}

        {/* <hr id={styles.or_line}></hr> */}
        {/* <h3 id={styles.or_text}>OR</h3> */}
          <div id={styles.voornaam_blok}>
            <label id={styles.voornaam_text} for={styles.voornaam_input}>Voornaam:<br></br>
              <input aria-label="Voornaam invoer" placeholder="" class={styles.input} type="text" id={styles.voornaam_input} autoFocus/>    
            </label>        
          </div>
          <div id={styles.achternaam_blok}>
            <label id={styles.achternaam_text} for={styles.achternaam_input}>Achternaam:<br></br>
              <input aria-label="Achternaam invoer" placeholder="" class={styles.input} type="text" id={styles.achternaam_input}/>
            </label>
          </div>
          <div id={styles.username_blok}>
            <label id={styles.username_text} for={styles.username_input}>Username:<br></br>
              <input aria-label="Username invoer" placeholder="" class={styles.input} type="text" id={styles.username_input}/>
            </label>
          </div>
          <div id={styles.email_blok}>
            <label id={styles.email_text} for={styles.email_input}>Email:<br></br>
              <input aria-label="Email invoer" placeholder="" class={styles.input} type="text" id={styles.email_input}/>
            </label>
          </div>
          <div id={styles.telnr_blok}>
            <label id={styles.telnr_text} for={styles.telnr_input}>Telefoonnummer:<br></br>
              <input aria-label="Telefoonnummer invoer" placeholder="" class={styles.input} type="text" id={styles.telnr_input}/>
            </label>
          </div>
          <div id={styles.postcode_blok}>
            <label id={styles.postcode_text} for={styles.postcode_input}>Postcode:<br></br>
              <input aria-label="Postcode invoer" placeholder="" class={styles.input} type="text" id={styles.postcode_input}/>
            </label>
          </div>

          <div id={styles.beperkinginvoerdiv}>
            {/* <div class="dropdown">
              <button onclick={myFunction()} class="dropbtn">Dropdown</button>
              <div id="myDropdown" class="dropdown-content">
                <a href="#home">Home</a>
                <a href="#about">About</a>
                <a href="#contact">Contact</a>
              </div>
            </div> */}
            {/* <select value={selectedOption1} onChange={handleDropdownChange1}>
              {dropdownOptions1.map((option) => (
                <option key={option.value} value={option.value}>
                  {option.label}
                </option>
              ))}
            </select> */}
            <input aria-label="Beperking invoer" type="text" id={styles.beperking_input} className="beperking_input" placeholder="Voeg beperking toe" value={inputValue} maxlength="60" onChange={(e) => setInputValue(e.target.value)}/>
            <button aria-label="Knop, voeg ingevoerde beperking toe" id={styles.addbeperking} onClick={addbeperkingToList}>+</button>
          </div>
          {/* <div id={styles.ingevoerdeBeperkingen} className="ingevoerdeBeperkingen">
            <ul>
              {beperkingen.map((item) => (
                <button id={styles.selectedbeperking} name={item.type} onClick={RemoveBeperking(item)}>{item.type}</button>
              ))}
            </ul>
          </div> */}
          <div id={styles.ingevoerdeBeperkingen} className="ingevoerdeBeperkingen">
            <ul>
              {beperkingen.map((item, index) => (
                <button aria-label={"Beperking: " + item.type + ". Klik om weg te halen"} key={index} id={styles.selectedbeperking} name={item.type} onClick={() => RemoveBeperking(item)}>
                  {item.type}
                </button>
              ))}
            </ul>
          </div>

          <div id={styles.hulpmiddelinvoerdiv}>
            {/* <select value={selectedOption2} onChange={handleDropdownChange2}>
              {dropdownOptions2.map((option) => (
                <option key={option.value} value={option.value}>
                  {option.label}
                </option>
              ))}
            </select> */}
            <input aria-label="Hulpmiddel invoer" type="text" id={styles.hulpmiddel_input} className="hulpmiddel_input" placeholder="Voeg hulpmiddel toe" value={inputValue2} maxlength="60" onChange={(f) => setInputValue2(f.target.value)}/>
            <button aria-label="Knop, voeg ingevoerde hulpmiddel toe" id={styles.addhulpmiddel} onClick={addhulpmiddelToList}>+</button>
          </div>
          <div id={styles.ingevoerdeHulpmiddelen} className="ingevoerdeHulpmiddelen">
            <ul>
              {hulpmiddelen.map((item, index) => (
                <button aria-label={"Hulpmiddel: " + item.type + ". Klik hier om weg te halen"} key={index} id={styles.selectedhulpmiddel} name={item.type} onClick={() => RemoveHulpmiddel(item)}>
                  {item.type}
                </button>
              ))}
            </ul>
          </div>
          
          <div>
            <h2 id={styles.checkboxTitle}>Participatie Type Onderzoeken</h2>
            <label>
              <input aria-label="Checkbox voor Interviews" id={styles.checkbox1} type="checkbox" name="checkbox1" checked={checkedItems.checkbox1 || false} onChange={handleCheckboxChange}/>Interviews</label>
            <br />
            <label>
              <input aria-label="Checkbox voor Groepsgesprekken" id={styles.checkbox2} type="checkbox" name="checkbox2" checked={checkedItems.checkbox2 || false} onChange={handleCheckboxChange}/>Groepsgresprekken</label>
            <br />
            <label>
              <input aria-label="Checkbox voor Online Onderzoeken" id={styles.checkbox3} type="checkbox" name="checkbox3" checked={checkedItems.checkbox3 || false} onChange={handleCheckboxChange}/>Online Onderzoeken</label>
            <br />
            <label>
              <input aria-label="Checkbox voor Engelstalige Onderzoeken" id={styles.checkbox4} type="checkbox" name="checkbox4" checked={checkedItems.checkbox4 || false} onChange={handleCheckboxChange}/>Engelstalige Onderzoeken</label>
          </div>

          <div>
            <h2 id={styles.benaderingTitle}>Voorkeur Benadering</h2>
            <label>
              <input aria-label="Voorkeur: Telefonisch benadering" id={styles.benader_option1} type="radio" name="benadering" value="benader_option1" checked={selectedOption === "benader_option1"} onChange={handleBenaderingOptionChange}/>Telefonisch
            </label>
            <br />
            <label>
              <input aria-label="Voorkeur: Alleen via Portal benaderd worden" id={styles.benader_option2} type="radio" name="benadering" value="benader_option2" checked={selectedOption === "benader_option2"} onChange={handleBenaderingOptionChange}/>Alleen via Portal
            </label>
          </div>

          <div>
            <h2 id={styles.commercieelTitle}>Benaderd worden door Commerciële Partijen</h2>
            <label>
              <input aria-label="Voorkeur: Benaderd worden door Commerciële Partijen op Ja" id={styles.commercieel_option1} type="radio" name="commercieleBenadering" value="commercieel_option1" checked={selectedCommercieleOption === "commercieel_option1"} onChange={handleCommercieelOptionChange}/>Ja
            </label>
            <br />
            <label>
              <input aria-label="Voorkeur: Benaderd worden door Commerciële Partijen op Nee" id={styles.commercieel_option2} type="radio" name="commercieleBenadering" value="commercieel_option2" checked={selectedCommercieleOption === "commercieel_option2"} onChange={handleCommercieelOptionChange}/>Nee
            </label>
          </div>

          <div id={styles.password_blok}>
            <label id={styles.password_text} for={styles.password_input}>Password:<br></br>
              <input aria-label="Password invoer" placeholder="" class={styles.input} type="text" id={styles.password_input}/>
            </label>
          </div>
          <div id={styles.confirmpassword_blok}>
            <label id={styles.confirmpassword_text} for={styles.confirmpassword_input}>Confirm Password:<br></br>
              <input aria-label="Herhaal password invoer" placeholder="" class={styles.input} type="text" id={styles.confirmpassword_input}/>
            </label>
          </div>
          <button aria-label="Registreer knop" id={styles.register_button}>Registreer</button>
          <p id={styles.loginquestion}>Al geregistreerd? <a aria-label="Al geregistreerd? Link naar de login page" href="/Googlelogin" id={styles.loginquestion}>Log In</a></p>
        </div>
      </div>
        <ContactGegevens>
        </ContactGegevens>
        </>
      );

}
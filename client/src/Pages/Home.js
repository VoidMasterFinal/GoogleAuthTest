import React from 'react';
import styles from  '../styles/Home.module.css';
import GuestBar from './Bars/GuestBar';
import ContactGegevens from './Bars/ContactGegevensBar'

export default function Home() {
  return (
    <div>
      <GuestBar>
      </GuestBar>
      <img id={styles.wachtkamer_img} src="/Images/wachtkamer_plant.png" alt="Wachtkamer Achtergrond"/>
      <div>
        <h1 id={styles.over_ons}>Over Ons</h1>
        <div id={styles.blok_1}>
          <img id={styles.hulpverlening} src="/Images/zorg.png" alt="Hulpverlening"/>
          <p id={styles.text1}>Registreer nu om deel te nemen aan onderzoeken en om live met bedrijven te chatten.<br></br><br></br>Uw deelname is zeer belangrijk!</p>
        </div>
      <div id={styles.icon_holder}>
        <img id={styles.onderzoek_icon} src="/Images/onderzoek_icon.png" alt="Formulier Icoon"/>
        <img id={styles.chat_icon} src="/Images/chat_icon.png" alt="Chat Icoon"/>
        <img id={styles.info_icon} src="/Images/info-icon.png" alt="Informatie Icoon"/>
      </div>
      <div id={styles.text_holder}>
        <p id={styles.onderzoek_text}>Belangrijke Onderzoeken</p>
        <p id={styles.chat_text}>Live Chats</p>
        <p id={styles.info_text}>Inzichtgevende Informatie</p>
      </div>
      <p id={styles.voor_bedrijven}>Voor Bedrijven</p>
        <div id={styles.blok_2}>
          <img id={styles.business_man} src="/Images/happy-business-man.png" alt="Blije Zakenman"/>
          <p id={styles.text2}>Richt gratis onderzoeken op met ervaringsdeskundigen en verzamel klikgedrag op uw website.<br></br><br></br>Chat met de ervaringsdeskundigen en verbeter de accessibility van uw website.</p>
        </div>
      </div>
      <ContactGegevens>
      </ContactGegevens>
    </div>
  );
};
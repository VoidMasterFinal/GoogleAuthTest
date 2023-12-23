import React from 'react';
import styles from '../../styles/GuestBar.module.css'

export default function GuestBar() {
  return (
    <nav class={styles.navbar}>
        <div class={styles.navbar__container}>
            <a href="/" id={styles.navbar__logo}><img src="/Images/logo_accessibility.png " alt="Accessibility Logo"/></a>
            <div class={styles.navbar__toggle} id={styles.mobile_menu}>
                <span class={styles.bar}></span>
                <span class={styles.bar}></span>
                <span class={styles.bar}></span>
            </div>
            <ul class={styles.navbar__menu}>
                <li class={styles.navbar__button}>
                    <a href="/" class={styles.navbar__links} id={styles.Lettergrotte}>Lettergrotte</a>
                </li>
                <li class={styles.navbar__button}>
                    <a href="/" class={styles.navbar__links} id={styles.Darkmode}>Darkmode</a>
                </li>
                <li class={styles.navbar__item}>
                    <a href="/Googlelogin" class={styles.button}>Login</a>
                </li>
                <li class={styles.navbar__item}>
                    <a href="/signup" class={styles.button}>Sign In</a>
                </li>
            </ul>
        </div>
    </nav>
);
};

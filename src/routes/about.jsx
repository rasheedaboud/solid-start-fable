import { A } from "@solidjs/router";

function About() {
    return         <div style="display: flex; flex-direction: column; align-items: center; justify-content: center; height: 100vh;  padding: 20px;">
            <h1 style="color: #333; font-size: 2.5rem; margin-bottom: 20px;">
                🎉 Welcome to Your Solid Start App! 🎉
            </h1>
            <p style="color: #555; font-size: 1.2rem; text-align: center; max-width: 600px;">
                Built with <strong>F#</strong>, <strong>Fable</strong>, and <strong>SolidJS</strong>, this app is designed to provide a delightful and type-safe experience for building modern web applications.
            </p>
            <A 
                style="margin-top: 30px; padding: 10px 20px; font-size: 1rem; background-color: #4caf50; color: white; border: none; border-radius: 5px; cursor: pointer;"
                href="https://fable.io/"    
                >
                Learn more Here
            </A>
        </div>

    ;
}

export default About;


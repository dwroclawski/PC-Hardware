<template>
  <div class="contact-view">
    <h1>Contact Us</h1>
    <p>Have a question or need help?</p>
    <p>Send us a message and we'll get back to you as soon as possible.</p>
    <form @submit.prevent="submitForm" class="contact-form">
      <input type="email" id="email" v-model="email" required placeholder="Email address*">

      <textarea id="message" v-model="message" required placeholder="What can we help with?*"></textarea>

      <button type="submit" class="select-button">Send</button>
    </form>
  </div>
</template>

<script lang="ts">
export default {
  data() {
    return {
      email: '',
      message: ''
    }
  },
  methods: {
    async submitForm() {
      const payload = {
        email: this.email,
        message: this.message
      };

      try {
        const response = await fetch(process.env.API_URL + 'Email/Send', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json'
          },
          body: JSON.stringify(payload)
        });

        if (!response.ok) {
          throw new Error('Network response was not ok');
        }

        alert('Email sent successfully');
      } catch (error) {
        console.error(error);
        alert('Failed to send email');
      }
    }
  }
}
</script>

<style scoped>
.contact-view {
  margin-top: 5rem;
}

.contact-view p:last-of-type {
  margin-bottom: 1rem;
}

.contact-form {
  display: flex;
  flex-direction: column;
}

.contact-form label {
  margin-top: 1rem;
}

.contact-form input,
.contact-form textarea {
  margin-bottom: 1rem;
  padding: 0.5rem;
  border: 1px solid #ccc;
  border-radius: 4px;
}

.contact-form textarea {
  resize: none;
  height: 15rem;
  width: 30rem;
}

.contact-form button {
  margin-top: 1rem;
  padding: 0.5rem 1rem;
}
</style>
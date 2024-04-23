<template>
  <div class="faq">
    <h1>Frequently Asked Questions</h1>
    <div v-for="question in faqList" :key="question.id" class="faq-item">
      <h3>{{ question.title }}</h3>
      <p>{{ question.answer }}</p>
    </div>
  </div>
</template>

<script lang="ts">
export default {
  data() {
    return {
      faqList: [
        {
          id: 1,
          title: 'What is the importance of a good PC configuration?',
          answer: 'A good PC configuration ensures that your computer can handle your specific needs, whether that be gaming, video editing, or other demanding tasks. It also helps your PC run smoothly and efficiently.'
        },
        {
          id: 2,
          title: 'How much RAM do I need?',
          answer: 'For basic tasks like web browsing and document editing, 8GB is usually sufficient. For more demanding tasks like gaming or video editing, 16GB or more is recommended.'
        },
        {
          id: 3,
          title: 'What is the role of the CPU in a PC?',
          answer: 'The CPU (Central Processing Unit) is the primary component of a computer that performs most of the processing inside the computer. It\'s often called the "brain" of the computer.'
        },
        {
          id: 4,
          title: 'What is the difference between HDD and SSD?',
          answer: 'HDDs (Hard Disk Drives) and SSDs (Solid State Drives) are both storage devices. HDDs are older and slower but cheaper per GB, while SSDs are faster but more expensive.'
        },
        {
          id: 5,
          title: 'What does the GPU do?',
          answer: 'The GPU (Graphics Processing Unit) handles rendering images, video and animations. It\'s especially important for tasks that involve 3D graphics, such as gaming and 3D modeling.'
        }
      ]
    }
  }
}
</script>

<style scoped>
.faq {
  margin-top: 5rem;
}

.faq-item h3{
  font-weight: bold;
}

.faq-item p {
  margin-bottom: 1.5em;
  max-width: 55rem;
}
</style>
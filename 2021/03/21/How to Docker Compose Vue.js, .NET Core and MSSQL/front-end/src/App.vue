<template>
  <h1 class="text-center mt-5">Cool Phone Book</h1>

  <div class="container mt-5">
    <table class="table table-dark">
      <thead>
        <tr>
          <th scope="col">#</th>
          <th scope="col">First Name</th>
          <th scope="col">Last Name</th>
          <th scope="col">Phone Number</th>
          <th scope="col">Address</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="phoneBookEntry in phoneBookEntries" :key="phoneBookEntry.Id">
          <td>{{ phoneBookEntry.Id }}</td>
          <td>{{ phoneBookEntry.firstName }}</td>
          <td>{{ phoneBookEntry.lastName }}</td>
          <td>{{ phoneBookEntry.phoneNumber }}</td>
          <td>{{ phoneBookEntry.address }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script lang="ts">
import { defineComponent, onMounted, ref } from "vue";
export default defineComponent({
  name: "Home",
  setup() {
    const phoneBookEntries = ref();

    onMounted(async () => {
      const url = `${process.env.VUE_APP_API_URL}/api/phone-book`;
      const response = await fetch(url);
      phoneBookEntries.value = await response.json();

      console.log(url);
      console.log(phoneBookEntries.value);
    });

    return { phoneBookEntries };
  },
});
</script>

<style>
</style>
